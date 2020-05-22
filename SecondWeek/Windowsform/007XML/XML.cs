using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _007XML
{
    public partial class XML : Form
    {
        const string FilePath = @"C:\Users\user\Desktop\CS\SecondWeek\Windowsform\007XML\";

        public XML()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvFile.Items.Clear();
            WebClient wc = new WebClient();
            string buffer = wc.DownloadString(string.Format("{0}WebXml.xml", FilePath));
            //DownloadString -> 요청한 리소스를 string으로 다운로드하고 String 반환.

            wc.Dispose();       //webClient 개체 리소스 해제

            StringReader sr = new StringReader(buffer);     //반환된 string을 읽어서 sr에 개체 생성.
            XmlDocument doc = new XmlDocument();        
            doc.Load(sr);           //sr에서 XML문서 로드.
            sr.Close();             //StringReader 닫기.

            XmlNodeList forecastNodes = doc.SelectNodes("xml_reply/human/human_entry");
            //XPath와 일치하는 노드(데이터들을 object로 만들어야 하는데 그런 역할을 하는것이 노드.)의 목록 선택한것을 
            //노드의 정렬된 컬렉션인 XmlNodeList에 할당.
            foreach(XmlNode node in forecastNodes)      //XmlNodeList의 요소 하나씩 꺼내옴.
            {
                this.lvFile.Items.Add(new ListViewItem(new String[] { GetNodeValue(node, "title") }));  //ListView 아이템에 추가.
            }
        }

        private string GetNodeValue(XmlNode parent, string name)
        {
            try
            {
                XmlAttribute attr = parent.SelectSingleNode(name).Attributes["name"];   
                //XPath식 title과 일치하는 첫번째 XmlNode선택하고 
                //미리 정의된 시스템 정보나 사용자 정의 지정정보를 대상 요소와 연결하는 Attributes속성을 이용해 name값을 검색하여 attr에 저장
                if (attr != null)
                    return attr.Value;      //'name' 노드의 값 반환.

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
