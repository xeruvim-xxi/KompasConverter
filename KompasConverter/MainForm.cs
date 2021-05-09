using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml;
using System.Windows.Forms;
using Kompas6API5;
using Kompas6Constants;
using KompasAPI7;
using KAPITypes;

namespace KompasConverter
{
    public struct SettingRastr
    {
        public short Format; // формат растра
        public short ColorType; // цвет вывода объектов
        public double Scale; // масштаб
        public short ColorBPP; // цветность растра
        public int Resolution; // разрешение растра

    }

    public partial class MainForm : Form
    {
        private KompasObject kompas;
        private IApplication kompas7;
        private SettingRastr setting;
        bool flag_Kompas = false;
        bool multiTiff = false;
        int kolLists = 1;


        public MainForm()
        {
            InitializeComponent();
            TestConnectKompas();
            LoadSettingRastr();
        }

        private bool SaveCDW_in_Rastr(Document2D doc)
        {
            DocumentParam docP = (DocumentParam)kompas.GetParamStruct((short)StructType2DEnum.ko_DocumentParam);
            if (docP == null)
            {
                kompas.ksMessage("Не удалось получить интерфейс DocumentParam");
                return false;
            }
            int t = doc.ksGetObjParam(doc.reference, docP);
            string filename = docP.fileName;
            filename = filename.Substring(0, filename.Length - 4);            
            RasterFormatParam formatRasret = doc.RasterFormatParam();
            //if (formatRasret.Init())
            //{
            //    kompas.ksMessage("Обнулились параметры RasterFormatParam");
            //}
            if (formatRasret == null) return false;
            if (setting.Format == 20)
            {
                formatRasret.format = 4;
            }
            else
            {
                formatRasret.format = setting.Format;
            }
            formatRasret.colorBPP = setting.ColorBPP;
            formatRasret.colorType = setting.ColorType;
            formatRasret.extResolution = setting.Resolution;
            formatRasret.extScale = setting.Scale;
            formatRasret.greyScale = false;
            formatRasret.onlyThinLine = false;
            formatRasret.multiPageOutput = multiTiff;
            if (kolLists == 1 || multiTiff)
            {
                string fileTiff_f = filename + "." + ConvertFormat(setting.Format);
                if (!doc.SaveAsToRasterFormat(fileTiff_f, formatRasret))
                {
                    return false;
                }
                return true;
            } 
            for (int i = 1; i< kolLists+1; i++)
            {
                string fileName_f = filename;
                string fileTiff_f = fileName_f  + "." + ConvertFormat(setting.Format);
                formatRasret.pages = i.ToString() + "-" +i.ToString();
                fileTiff_f = fileName_f + "(" + i.ToString() + ")" +  "." + ConvertFormat(setting.Format);               
                if (!doc.SaveAsToRasterFormat(fileTiff_f, formatRasret))
                {
                    return false;
                }
            }
            return true;
        }

        public void LoadSettingRastr()
        {
            string File = "Setting.xml";
            if (!System.IO.File.Exists(File))
            {
                MessageBox.Show("Не найден файл настроек.");
                setting.Format = 4;
                setting.ColorType = 1;
                setting.Scale = 1.0;
                setting.ColorBPP = 1;
                setting.Resolution = 150;
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
                kompas.ksMessage("Не удалость прочитать файл настроек.");
                setting.Format = 4;
                setting.ColorType = 1;
                setting.Scale = 1.0;
                setting.ColorBPP = 1;
                setting.Resolution = 150;
            }
            string str = ConvertFormat(setting.Format);
        }

        public string ConvertFormat(short format)
        {
            string strformat = "tif";
            switch (format)
            {
                case 0:
                    strformat = "bmp";
                    break;
                case 2:
                    strformat = "jpg";
                    break;
                case 4:
                    strformat = "tif";
                    multiTiff = false;
                    break;
                case 20:
                    strformat = "tif";
                    multiTiff = true;
                    break;
                default:
                    strformat = "tif";
                    break;
            }
            return strformat;
        }

        private void bConvertActiveDrawing_Click(object sender, EventArgs e)
        {
            TestConnectKompas();
            if (!flag_Kompas) return;

            Document2D doc = kompas.ActiveDocument2D();
            if (doc == null)
            {
                kompas.ksMessage("Активный документ не является чертежом.");
                return;
            }
            long typedoc = kompas.ksGetDocumentType(doc.reference);
            if ((typedoc < 1) || (typedoc > 2))
            {
                kompas.ksMessage("Активный документ не является чертежом.");
                return;
            }
            KompasDocument kdoc = kompas.TransferInterface(doc, (int)ksAPITypeEnum.ksAPI7Dual, 0);
            if (kdoc == null)
            {
                kompas.ksMessage("Не удалось преобразовать объект");
                return;
            }
            ILayoutSheets lists = kdoc.LayoutSheets;
            kolLists = lists.Count;
            //if (kolLists > 1)
            //{
            //    kompas.ksMessage("Количество листов в документе: " + kolLists.ToString());
            //}
            if (!SaveCDW_in_Rastr(doc))
            {
                kompas.ksMessage("Ошибка! Чертеж не переведен");
                return;
            }
            kompas.ksMessage("Чертеж успешно переведен");
            kolLists = 1;
        }

        private void bConvertAllDrawing_Click(object sender, EventArgs e)
        {
            TestConnectKompas();
            if (!flag_Kompas) return;
            Documents docs = kompas7.Documents;
            int k = docs.Count;
            if (k == 0)
            {
                kompas.ksMessage("Нет открытых документов");
                return;
            }
            for (int i = 0; i < k; i++)
            {
                KompasDocument kdoc = (KompasDocument)docs[i];
                if (kdoc.DocumentType == DocumentTypeEnum.ksDocumentDrawing)
                {
                    kolLists = 1;
                    ILayoutSheets lists = kdoc.LayoutSheets;
                    kolLists = lists.Count;
                    //if (kolLists > 1)
                    //{
                    //    kompas.ksMessage("Количество листов в документе: " + kolLists.ToString());
                    //}
                    Document2D doc2 = kompas.Document2D();
                    doc2 = kompas.TransferInterface(kdoc, (int)ksAPITypeEnum.ksAPI5Auto, 0);
                    if (doc2 == null)
                    {
                        kompas.ksMessage("Не удалось преобразовать объект");
                        return;
                    }
                    if (!SaveCDW_in_Rastr(doc2))
                    {
                        kompas.ksMessage("Ошибка! Чертеж не переведен");
                        return;
                    }
                }
            }
            kompas.ksMessage("Чертежи успешно переведены");
            kolLists = 1;
        }

        private void bSetting_Click(object sender, EventArgs e)
        {
            FormSetting formS = new FormSetting();
            if (formS.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Настройки сохранены");
                LoadSettingRastr();
            }

        }

        private void TestConnectKompas()  // подключение к Компасу
        {
            try
            {
                kompas = (KompasObject)Marshal.GetActiveObject("KOMPAS.Application.5");
                kompas7 = kompas.ksGetApplication7();
                flag_Kompas = true;
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к Компас 3D. Запустите его.");
                flag_Kompas = false;
            }
        }

    }
}
