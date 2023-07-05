using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Vistas
{
    class Estilo
    {
        public static void aplicar(Form form)
        {
            form.BackColor = System.Drawing.Color.Teal;
            form.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    aplicar((Button)control);
                }
                if (control is DataGridView)
                {
                    aplicar((DataGridView)control);
                }
                if (control is GroupBox)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is Button)
                        {
                            aplicar((Button)control2);
                        }
                        if (control2 is DataGridView)
                        {
                            aplicar((DataGridView)control2);
                        }
                    }
                }
            }
        }

        public static void titulo(Label label)
        {
            label.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private static void aplicar(Button button)
        {
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.MouseLeave += new System.EventHandler(btnAceptarLogin_MouseLeave);
            button.MouseHover += new System.EventHandler(btnAceptarLogin_MouseHover);
        }

        private static void aplicar(DataGridView datagridview)
        {
            datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            datagridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private static void btnAceptarLogin_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightGreen;
            //((Button)sender).Size = new Size(140, 35);
            //((Button)sender).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Button)sender).FlatAppearance.BorderSize = 0;
        }

        private static void btnAceptarLogin_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            //((Button)sender).Size = new Size(135, 30);
            //((Button)sender).Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Button)sender).FlatAppearance.BorderSize = 2;
        }


    }
}
