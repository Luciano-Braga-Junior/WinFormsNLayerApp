using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace MordernFlatUi
{
    public partial class FormMainMenu : Form
    {
        //Campos
        private IconButton botaoCorrente;
        private Panel botaoBordaEsquerda;

        //Construtor
        public FormMainMenu()
        {
            InitializeComponent();
            botaoBordaEsquerda = new Panel();
            botaoBordaEsquerda.Size = new Size(7, 60);
            panelMenu.Controls.Add(botaoBordaEsquerda);
        }
        //Struturas
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
            //Metodos
            private void ActivateButton(object sender, Color color)
        {
            if(sender != null)
            {
                DisableButton();
                //Botão
                botaoCorrente = (IconButton) sender;
                botaoCorrente.BackColor = Color.FromArgb(37,36,81);
                botaoCorrente.ForeColor = color;
                botaoCorrente.TextAlign = ContentAlignment.MiddleCenter;
                botaoCorrente.IconColor = color;
                botaoCorrente.TextImageRelation = TextImageRelation.TextBeforeImage;
                botaoCorrente.ImageAlign = ContentAlignment.MiddleRight;

                //Botão de Borda Esquerda
                botaoBordaEsquerda.BackColor = color;
                botaoBordaEsquerda.Location = new Point(0,botaoCorrente.Location.Y);
                botaoBordaEsquerda.Visible = true;
                botaoBordaEsquerda.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (botaoCorrente != null)
            {
                botaoCorrente.BackColor = Color.FromArgb(31, 30, 68);
                botaoCorrente.ForeColor = Color.Gainsboro;
                botaoCorrente.TextAlign = ContentAlignment.MiddleLeft;
                botaoCorrente.IconColor = Color.Gainsboro;
                botaoCorrente.TextImageRelation = TextImageRelation.ImageBeforeText;
                botaoCorrente.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }
    }
}
