namespace WinForms_StringMethoing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SplitName_Click(object sender, EventArgs e)
        {
            string fullName = "", firstname = "", lastname = "", title = "";
            int x = 0;
            //กำจัด Space หน้าสุดออกหลังสุกออก
           fullName = txt_Fullname.Text.Trim();
            // ตรวจสอบว่าคำนำหน้าที่ต้องการหรือไม่  "นางสาว" "นาง" "นาย"
            // ตัดคำนำหน้าออกไป
            if (fullName.StartsWith("นางสาว")) 
            {
                x = 6;
                title = fullName.Substring(0,x);
               
            }
            else if (fullName.StartsWith("นาง") || fullName.StartsWith("นาย"))
            {
                x = 3;
                title=fullName.Substring(0,x);
               
            } 
            fullName = fullName.Substring(x).Trim();
            //MessageBox.Show(title + "\n" + fullName);
            // หาตำแหน่งช่องว่างระหว่างชื่อนามสกุล
            x = fullName.IndexOf(" ");
            // ตัดตั้งแต่ตัวที่ 0 จนถึงตำแหน่งช่องว่างจะได้ชื่อ
            firstname = fullName.Substring(0,x).Trim();
            // ตัดตั้งแต่ตำแหน่งช่องว่าง ไปจนหมดข้อคอวามจะได้นามสกุล
            lastname = fullName.Substring(x).Trim();
            // แสดงผลใน Textbox
            txt_Title.Text = title;
            txt_FirstName.Text = firstname;
            txt_LastName.Text = lastname;
            
        }
    }
}
