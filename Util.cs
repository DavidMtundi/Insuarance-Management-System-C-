using Bunifu.Framework.UI;
using FontAwesome.Sharp;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insuarance
{
    public static class Util
    {
        public static string strfilename;
        public static string strsafefilename;
        public static string strsavefileas;
        public static string folderpicpath = @"C:\programfiles\insuarance\pictures";
        public static int bunifuseperator = 0;

        public static void adddocumenttodatagridview(string path, DataGridView dg,string type)
        {
            string imgPath;
            imgPath = Path.Combine(folderpicpath, path.ToString());
            Image imageFile = Image.FromFile(imgPath);
            if (imgPath != null)
            {
                //img.Image=imgPath;
                dg.Rows.Add(imageFile, type);
                dg.RowTemplate.MinimumHeight = 40;
                
            }
            else
            {
                MessageBox.Show("Invalid Path detected");
            }
        }
        public static  void shownotification(string msg, NotificationForm.enmType type)
        {
            NotificationForm frm = new NotificationForm();
            frm.showAlert(msg, type);
        }
        /// <summary>
        /// This clears all controls in forms
        /// </summary>
        /// <param name="frm"></param>
        public static void clearallformcontrols(Form frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is BunifuMaterialTextbox)
                {
                    BunifuMaterialTextbox tx = (BunifuMaterialTextbox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is TextBox)
                {
                    TextBox tx = (TextBox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox tx = (ComboBox)control;
                    if (tx.Items.Count >0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is BunifuDropdown)
                {
                    BunifuDropdown tx = (BunifuDropdown)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.selectedIndex = 1;
                    }
                    else
                    {
                        tx.selectedIndex = -1;
                    }
                }
                if (control is MetroComboBox)
                {
                    MetroComboBox tx = (MetroComboBox)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is PictureBox)
                {
                    PictureBox tx = (PictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }
                if (control is IconPictureBox)
                {
                    IconPictureBox tx = (IconPictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }

            }
        }
        /// <summary>
        /// Clears all controls in panels
        /// </summary>
        /// <param name="frm"></param>
        public static void clearallpanelcontrols(Panel frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is BunifuMaterialTextbox)
                {
                    BunifuMaterialTextbox tx = (BunifuMaterialTextbox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is TextBox)
                {
                    TextBox tx = (TextBox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox tx = (ComboBox)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is BunifuDropdown)
                {
                    BunifuDropdown tx = (BunifuDropdown)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.selectedIndex = 1;
                    }
                    else
                    {
                        tx.selectedIndex = -1;
                    }
                }
                if (control is MetroComboBox)
                {
                    MetroComboBox tx = (MetroComboBox)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is PictureBox)
                {
                    PictureBox tx = (PictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }
                if (control is IconPictureBox)
                {
                    IconPictureBox tx = (IconPictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }

            }
        }
        /// <summary>
        /// Clears all usercontrol controls
        /// </summary>
        /// <param name="frm"></param>
        public static void clearallusercontrolcontrols(UserControl frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is BunifuMaterialTextbox)
                {
                    BunifuMaterialTextbox tx = (BunifuMaterialTextbox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is TextBox)
                {
                    TextBox tx = (TextBox)control;
                    if (tx.Text != "")
                    {
                        tx.Text = "";
                    }
                }
                if (control is ComboBox)
                {
                    ComboBox tx = (ComboBox)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is BunifuDropdown)
                {
                    BunifuDropdown tx = (BunifuDropdown)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.selectedIndex = 1;
                    }
                    else
                    {
                        tx.selectedIndex = -1;
                    }
                }
                if (control is MetroComboBox)
                {
                    MetroComboBox tx = (MetroComboBox)control;
                    if (tx.Items.Count > 0)
                    {
                        tx.SelectedIndex = 1;
                    }
                    else
                    {
                        tx.SelectedIndex = -1;
                    }
                }
                if (control is PictureBox)
                {
                    PictureBox tx = (PictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }
                if (control is IconPictureBox)
                {
                    IconPictureBox tx = (IconPictureBox)control;
                    if (tx.Image != null)
                    {
                        tx.Image = tx.InitialImage;
                    }
                    else
                    {
                        tx.Image = tx.InitialImage;
                    }
                }

            }
        }
        public static void createcircularpicturebox(Control pc)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, pc.Width, pc.Height);
            pc.Region = new System.Drawing.Region(p);
           // pc.SizeMode = PictureBoxSizeMode.Zoom;
           // base.OnPaint(pc);
        }
        public static void exporttoexcell(BunifuCustomDataGrid dg)
        {

            if (dg.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dg.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dg.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        if ((dg.Rows[i].Cells[j].Value == null)||(dg.Rows[i].Cells[j].Value.ToString() == ""))
                        {
                            dg.Rows[i].Cells[j].Value = 0;
                        }
                        xcelApp.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("No rows to convert");
            }

        }
        public static void changeseperatorvalues()
        {
            if (bunifuseperator == 1)
            {
               // panelcustomerdetailstab.
            }
        }
        public static void sendemail(BunifuMaterialTextbox textto,BunifuMaterialTextbox txthead,RichTextBox emailmessage)
        {
            if (textto.Text == "" || textto.Text == "  Email" || txthead.Text == "" || txthead.Text == "  Subject")
            {
                MessageBox.Show("please enter Email and Subject", "Send fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string to, from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = textto.Text;
                from = "mtundidavid@gmail.com";
                pass = "Mr.Robot1";
                messageBody = emailmessage.Text;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "From : " + "<br>Message: " + messageBody;
                message.Subject = txthead.Text;
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    DialogResult code = MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (code == DialogResult.OK)
                    {
                        txthead.Text="";
                        emailmessage.Clear();
                        //txtmess.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public static void checkiffolderexists()
        {
            // string path = @"C:\MP_Upload";
            try
            {
                if (!Directory.Exists(folderpicpath))
                {
                    Directory.CreateDirectory(folderpicpath);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public static void getdraganddroppiandpath(PictureBox pc)
        {
            checkiffolderexists();
            strfilename = pc.ImageLocation;
           // strsafefilename = pc. ;
            strsavefileas = folderpicpath + strsafefilename + ".jpg";
            //save the image to a given folder then save the path to a database
            if (!File.Exists(strsavefileas))
            {
                File.Copy(strfilename, strsavefileas);
                Image img = Image.FromFile(strsavefileas);
                pc.Image = img;

            }
            else
            {
                MessageBox.Show("File Exists in the database");
            }
        }
        public static void openfiledialogueandsavepath(PictureBox pc)
        {
            checkiffolderexists();
            OpenFileDialog openfiledialogue1 = new OpenFileDialog();
            openfiledialogue1.Filter =
                        "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF" ;
            openfiledialogue1.FilterIndex = 1;
            if (openfiledialogue1.ShowDialog() == DialogResult.OK)
            {
                strfilename = openfiledialogue1.FileName;
                strsafefilename = openfiledialogue1.SafeFileName;
                strsavefileas = folderpicpath + strsafefilename + ".jpg";
                //save the image to a given folder then save the path to a database
                if (! File.Exists(strsavefileas))
                {
                    File.Copy(strfilename, strsavefileas);
                    Image img = Image.FromFile(strsavefileas);
                    pc.Image = img;

                }
                else
                {
                    MessageBox.Show("File Exists in the database");
                }
            }
        }
    }

}
