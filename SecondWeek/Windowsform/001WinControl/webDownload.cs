using System;
using System.Windows.Forms;
using System.Diagnostics;   //시스템 프로세스, 이벤트 로그 및 성능 카운터와 상호 작용할 수 있는 클래스를 제공

namespace _001WinControl
{
    public partial class webDownload : Form
    {
        Boolean isBusy;     //progressbar 상태 나타냄.   //웹 요청이 진행 중인지 여부를 나타냄. 웹 요청이 진행중이면 true, 그렇지 않으면 false.
        private string filePath = null;     //파일 경로

        public webDownload()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if(this.fbdFile.ShowDialog() == DialogResult.OK)
            {
                this.btnDown.Enabled = true;                //다운로드 버튼의 컨트롤 사용여부(enabled)을 true로
                filePath = this.fbdFile.SelectedPath;       //filePath에 선택한 파일 경로 할당.
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (isBusy)
            {
                webClient.CancelAsync();        //보류중인 비동기 작업을 취소. 다운로드를 진행하기 위한 초기화 작업.
                                                //진행중인 비동기 작업이 없으면 이 메서드는 아무것도 수행하지 않음. 
                isBusy = false;
            }
            else
            {
                var strFileName = this.txtUri.Text.Split(new Char[] { '/' });       //txtUrl Text값을 /를 기준으로 분할
                
                System.Array.Reverse(strFileName);      //strFileName값을 역순으로 작업 (???)


                try 
                {
                    Uri uri = new Uri(this.txtUri.Text);
                    webClient.DownloadFileAsync(uri, filePath + @"\" + strFileName[0]);
                    isBusy = true;
                }
                catch
                {
                    MessageBox.Show("uri값을 입력해 주세요", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                //webClient.DownloadFileAsync(address, fileName) 메서드
                // -> address : 다운로드할 리소스의 URI / fileName : 로컬 컴퓨터에 저장할 파일의 이름.
                

                if (this.btnDown.Enabled == false)
                {
                    MessageBox.Show("다운로드가 실패하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void webClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
            //비동기 다운로드의 진행 상태가 바뀔 때마다 발생하는 이벤트.
        {
            this.pgbDownload.Value = e.ProgressPercentage;      //비동기 작업의 진행을 나타내는 백분율 값을 pgbDownload 컨트롤 Value속성에 입력.
        }

        private void webClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            isBusy = false;
            this.btnDown.Enabled = false;
            if (e.Error == null)
            {
                if (this.cbOpen.Checked == false)
                {
                    MessageBox.Show("다운로드가 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.FileName = filePath;
                    myProcess.Start();
                }
            }
            else
                MessageBox.Show("다운로드가 실패하였습니다. : " + e.Error.Message.ToString());
        }
    }
}
