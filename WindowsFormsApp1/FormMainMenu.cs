using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_DataBase : Form
    {
        /// <summary>
        /// Поля
        /// </summary>
        private Button currentButton; // для виділення кнопки
        private Random random; // для рандомног вибору
        private int tempIndex; // для перевірки індексу елементу
        private Form activeForm; // для перевірки на активінсть форми
        /// <summary>
        /// Конструктор форми
        /// </summary>
        public Form_DataBase()
        {
            InitializeComponent();
            random = new Random();
            panelMenu.BackColor = Color.Black;
            panelLogo.BackColor = Color.Black;
            panelTitleBar.BackColor = Color.Black;
            panelDesktop.BackColor = Color.Black;
            
        }
        /// <summary>
        /// Вибирає колір
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Активація кнопки
        /// </summary>
        /// <param name="btnSender"></param>
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
        /// <summary>
        /// Деактивація кнопки
        /// </summary>
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
        /// <summary>
        /// Для відкриття додаткової форми
        /// </summary>
        /// <param name="childForm"></param>
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
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterprise_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Enterprise";
            OpenChildForm(new FormEnterprise());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArea_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Area";
            OpenChildForm(new FormArea());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrigade_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Brigade";
            OpenChildForm(new FormBrigade());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Workers";
            OpenChildForm(new FormWorkers());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkshop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Workshop";
            OpenChildForm(new FormWorkshop());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductCategory";
            OpenChildForm(new FormProductCategory());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductType_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductType";
            OpenChildForm(new FormProductType());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductAttributes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "ProductAttributes";
            OpenChildForm(new FormProductAttributes());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkcycle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Workcycle";
            OpenChildForm(new FormWorkcycle());
        }
        /// <summary>
        /// Відкриває нову форму з даними про таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestingProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "TestingProduct";
            OpenChildForm(new FormTestingProduct());
        }
    }
}
