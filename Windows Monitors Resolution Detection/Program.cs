using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Monitors_Resolution_Detection
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(string.Format("전체 해상도 : {0}x{1}", SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height));
            Screen[] screens = Screen.AllScreens;
            Console.WriteLine(string.Format("감지된 모니터 개수 : {0}개", screens.Length));
            Console.Write("\n");
            for (int i = 0; screens.Length > i; i++) {
                Screen scrn = screens[i];
                Console.WriteLine(string.Format("{0}번째 모니터 이름 : {1}", i + 1, scrn.DeviceName));
                Console.WriteLine(string.Format("{0}번째 모니터 해상도 : {1}x{2}", i + 1, scrn.Bounds.Width, scrn.Bounds.Height));
                Console.WriteLine(string.Format("{0}번째 모니터 비트수 : {1}", i + 1, scrn.BitsPerPixel));
                Console.WriteLine(string.Format("{0}번째 모니터 작업 영역 : {1}", i + 1, scrn.WorkingArea.ToString()));
                if (scrn.Primary) Console.WriteLine(string.Format("{0}번째 모니터는 기본 모니터입니다.", i + 1));
                Console.Write("\n");
            }
            Console.Write("아무 키를 입력하면 창이 종료됩니다.");
            Console.ReadKey();
        }
    }
}
