using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testdemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TestLogin_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Mở trình duyệt và điều hướng đến trang web cần đăng nhập
                driver.Navigate().GoToUrl("https://stage.moosocial.com/php81/moo-320/"); // Thay thế bằng URL của trang web bạn muốn đăng nhập

                // Tìm và click vào phần tử để mở form đăng nhập (ví dụ: button hoặc link)
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"UserLoginForm\"]/div[2]/div[2]/input")); // Thay thế bằng XPath hoặc CSS Selector của nút đăng nhập
                loginButton.Click();

                // Nhập thông tin đăng nhập (ví dụ: tên đăng nhập và mật khẩu)
                IWebElement usernameField = driver.FindElement(By.Id("login_email")); // Thay thế bằng id hoặc selector của trường tên đăng nhập
                usernameField.SendKeys("user1@socialloft.com");

                IWebElement passwordField = driver.FindElement(By.Id("login_password")); // Thay thế bằng id hoặc selector của trường mật khẩu
                passwordField.SendKeys("654321");

                //Đóng màn hình đen khi chạy chương trình
                ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
                chrome.HideCommandPromptWindow = true;

                // Submit form để đăng nhập
                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit']")); // Thay thế bằng XPath hoặc CSS Selector của nút submit
                submitButton.Click();

                MessageBox.Show("Chức năng đăng nhập đạt yêu cầu!");
            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("Không tìm thấy phần tử: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt sau khi hoàn thành
                driver.Quit();
            }
        }

        private void btn_TestRegister_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Điều hướng đến trang đăng ký nhân viên của trang web
                driver.Navigate().GoToUrl("https://example.com/register"); // Thay thế bằng URL của trang đăng ký nhân viên

                // Điền thông tin đăng ký
                driver.FindElement(By.Id("email")).SendKeys("test@example.com");
                driver.FindElement(By.Id("name")).SendKeys("Test User");
                driver.FindElement(By.Id("phone")).SendKeys("123456789");
                driver.FindElement(By.Id("birthday")).SendKeys("2000-01-01");
                driver.FindElement(By.Id("password")).SendKeys("testpassword");
                driver.FindElement(By.Id("confirm_password")).SendKeys("testpassword");

                // Upload ảnh (đường dẫn file ảnh cần thay đổi theo đường dẫn thực tế)
                string imagePath = @"C:\path\to\image.jpg";
                if (File.Exists(imagePath))
                {
                    driver.FindElement(By.Id("image_upload")).SendKeys(imagePath);
                }

                // Submit form đăng ký
                driver.FindElement(By.Id("register_button")).Click();

                MessageBox.Show("Đăng ký nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt sau khi hoàn thành
                driver.Quit();
            }
        }
    }
}
