using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_DataBase : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm; // переменная для отслеживания активной формы
        // Constructor
        public Form_DataBase()
        {
            InitializeComponent();
            random = new Random();
            panelMenu.BackColor = Color.Black;
            panelLogo.BackColor = Color.Black;
            panelTitleBar.BackColor = Color.Black;
            panelDesktop.BackColor = Color.Black;
            
        }

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
              index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void DisableButton() 
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 30, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // закрыть предыдущую активную форму

            activeForm = childForm; // установить новую активную форму
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelTitleBar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
        }

        private void Form_DataBase_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterprise_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Enterprise";
            OpenChildForm(new FormEnterprise());
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Area";
            OpenChildForm(new FormArea());
        }

        private void btnBrigade_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Brigade";
            OpenChildForm(new FormBrigade());
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkshop_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductCategory";
            OpenChildForm(new FormProductCategory());
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductType";
            OpenChildForm(new FormProductType());
        }

        private void btnProductAttributes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductAttributes";
            OpenChildForm(new FormProductAttributes());
        }
    }
}
