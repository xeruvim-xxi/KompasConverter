using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace KompasConverter
{
    public partial class FormSetting : Form
    {
        SettingRastr setting;

        public FormSetting()
        {
            InitializeComponent();
            LoadSettingRastr();
            cBFormat.SelectedIndex= cBFormat.FindString(ConvertFormat(setting.Format));
            cBColor.SelectedIndex = cBColor.FindString(ConvertColorType(setting.ColorType));
            nScale.Value = (decimal)setting.Scale;
            cBColorBPP.SelectedIndex = cBColorBPP.FindString(ConvertColorBPP(setting.ColorBPP));
            cBResolution.Text = setting.Resolution.ToString();
        }

        private void bSaveSetting_Click(object sender, EventArgs e)
        {
            setting.Format = ConvertFormat(cBFormat.Text);
            setting.ColorType = ConvertColorType(cBColor.Text);
            setting.Scale = (double)nScale.Value;
            setting.ColorBPP = ConvertColorBPP(cBColorBPP.Text);
            setting.Resolution = Convert.ToInt32(cBResolution.Text);
            SaveSettingRastr();            
        }

        public void SaveSettingRastr()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<setting>
            <format></format>
            <colortype></colortype>
            <scale></scale>
            <colorbpp></colorbpp>
            <resolution></resolution>
            </setting>");
            doc.ChildNodes[0].SelectSingleNode(@"/setting/format", null).InnerText = setting.Format.ToString();
            doc.ChildNodes[0].SelectSingleNode(@"/setting/colortype", null).InnerText = setting.ColorType.ToString();
            doc.ChildNodes[0].SelectSingleNode(@"/setting/scale", null).InnerText = setting.Scale.ToString();
            doc.ChildNodes[0].SelectSingleNode(@"/setting/colorbpp", null).InnerText = setting.ColorBPP.ToString();
            doc.ChildNodes[0].SelectSingleNode(@"/setting/resolution", null).InnerText = setting.Resolution.ToString();
            doc.Save("Setting.xml");            
        }

        public void LoadSettingRastr()
        {
            string File = "Setting.xml";
            if (!System.IO.File.Exists(File))
            {
               // MessageBox.Show("Не найден файл настроек.");
                setting.Format = 4;
                setting.ColorType = 1;
                setting.Scale = 1.0;
                setting.ColorBPP = 1;
                setting.Resolution = 150;
                SaveSettingRastr();
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(File);
            try
            {
                setting.Format = (short)Convert.ToDecimal(doc.ChildNodes[0].SelectSingleNode(@"/setting/format", null).InnerText);
                setting.ColorType = (short)Convert.ToDecimal(doc.ChildNodes[0].SelectSingleNode(@"/setting/colortype", null).InnerText);
                setting.Scale = Convert.ToDouble(doc.ChildNodes[0].SelectSingleNode(@"/setting/scale", null).InnerText);
                setting.ColorBPP = (short)Convert.ToDecimal(doc.ChildNodes[0].SelectSingleNode(@"/setting/colorbpp", null).InnerText);
                setting.Resolution = Convert.ToInt32(doc.ChildNodes[0].SelectSingleNode(@"/setting/resolution", null).InnerText);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалость прочитать файл настроек.");
                setting.Format = 4;
                setting.ColorType = 1;
                setting.Scale = 1.0;
                setting.ColorBPP = 1;
                setting.Resolution = 150;
            }
        }

        public short ConvertFormat(string str)
        {
            switch (str)
            {
                case "BMP":
                    return 0;
                case "JPEG":
                    return 2;
                case "TIFF":
                    return 4;
                case "TIFF(многостраничный)":
                    return 20;
                default:
                    return 4;
            }
        }

        public string ConvertFormat(short format)
        {
            string strformat = "TIFF";
            switch (format)
            {
                case 0:
                    strformat = "BMP";
                    break;
                case 2:
                    strformat = "JPEG";
                    break;
                case 4:
                    strformat = "TIFF";
                    break;
                case 20:
                    strformat = "TIFF(многостраничный)";
                    break;
                default:
                    strformat = "TIFF";
                    break;
            }
            return strformat;
        }

        public short ConvertColorType (string str)
        {
            switch (str)
            {
                case "черный":
                    return 1;
                case "установленный для объекта":
                    return 3;
                default:
                    return 1;
            }
        }

        public string ConvertColorType(short colortype)
        {
            switch (colortype)
            {
                case 1:
                    return "черный";
                case 3:
                    return "установленный для объекта";
                default:
                    return "черный";
            }
        }

        public short ConvertColorBPP(string str)
        {
            switch (str)
            {
                case "монохромный":
                    return 1;
                case "16 цветов":
                    return 4;
                case "256 цветов":
                    return 8;
                case "24 разряда":
                    return 24;
                default:
                    return 1;
            }
        }

        public string ConvertColorBPP(short colorbpp)
        {
            switch (colorbpp)
            {
                case 1:
                    return "монохромный";
                case 4:
                    return "16 цветов";
                case 8:
                    return "256 цветов";
                case 24:
                    return "24 разряда";
                default:
                    return "монохромный";
            }            
        }

        private void cBFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            short format = ConvertFormat(cBFormat.Text);
            if (format == 2)
            {
                cBColorBPP.SelectedIndex = cBColorBPP.FindString(ConvertColorBPP(24));
                cBColorBPP.Enabled = false;
            }
            else
            {
                cBColorBPP.Enabled = true;
            }
        }
    }
}
