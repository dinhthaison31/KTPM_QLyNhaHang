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
using OpenQA.Selenium.Support.UI;

namespace testdemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Test dang nhap
        private void btn_TestLogin_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Mở trình duyệt và điều hướng đến trang web cần đăng nhập
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login"); // Thay thế bằng URL của trang web bạn muốn đăng nhập

                // Tìm và click vào phần tử để mở form đăng nhập (ví dụ: button hoặc link)
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input")); // Thay thế bằng XPath hoặc CSS Selector của nút đăng nhập
                loginButton.Click();

                // Nhập thông tin đăng nhập (ví dụ: tên đăng nhập và mật khẩu)
                IWebElement usernameField = driver.FindElement(By.Id("email")); // Thay thế bằng id hoặc selector của trường tên đăng nhập
                usernameField.SendKeys("abcd123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password")); // Thay thế bằng id hoặc selector của trường mật khẩu
                passwordField.SendKeys("Admin@123");

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


        //Test dang ky
        private void btn_TestRegister_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Điều hướng đến trang đăng ký nhân viên của trang web
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/register"); // Thay thế bằng URL của trang đăng ký nhân viên

                // Điền thông tin đăng ký
                driver.FindElement(By.Id("email")).SendKeys("abcd12@gmail.com");
                driver.FindElement(By.Id("name")).SendKeys("Tu nhi");
                driver.FindElement(By.Id("phone")).SendKeys("0912333345");
                // Tìm trường nhập ngày sinh
                IWebElement birthDayInput = driver.FindElement(By.Id("birth-day"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", birthDayInput, "2001-10-20");

                //  driver.FindElement(By.Id("birth-day")).SendKeys("20-Oct-2001");


                driver.FindElement(By.Id("password")).SendKeys("Admin@123");
                driver.FindElement(By.Id("confirmPassword")).SendKeys("Admin@123");

                // Upload ảnh (đường dẫn file ảnh cần thay đổi theo đường dẫn thực tế)
                string imagePath = @"C:\Users\nguye\Downloads\415939203_332048676296612_3045788807400134481_n.jpg";
                if (File.Exists(imagePath))
                {
                    driver.FindElement(By.Id("imageId")).SendKeys(imagePath);
                }

                // Submit form đăng ký
                // driver.FindElement(By.Id("submit")).Click();

                IWebElement registerButton = driver.FindElement(By.XPath("//*[@id=\"user\"]/input"));
                registerButton.Click();

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

        //Test booking
        private void btn_testbooking_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login");

                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("abcd123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input"));
                loginButton.Click();

                IWebElement bookingButton = driver.FindElement(By.LinkText("Booking"));
                bookingButton.Click();

                // Tìm trường nhập ngày sinh
                IWebElement eventDate = driver.FindElement(By.Id("date"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", eventDate, "2024-01-29");

                SelectElement timeDropdown = new SelectElement(driver.FindElement(By.Id("type_day")));
                timeDropdown.SelectByText("affternoon");

                IWebElement tableField = driver.FindElement(By.Id("countTable"));
                tableField.SendKeys("25");

                IWebElement noteField = driver.FindElement(By.Id("note"));
                noteField.SendKeys("12g ");

                IWebElement hallSelectButton = driver.FindElement(By.XPath("//*[@id=\"wedding-hall\"]/button"));
                hallSelectButton.Click();

                //sanh rose
                IWebElement roseHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[1]/div/button"));
                roseHallSelect.Click();
                ////sanh Camellia
                //IWebElement camelliaHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[3]/div/button"));
                //camelliaHallSelect.Click();
                ////sanh Tulip
                //IWebElement tulipHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[4]/div/button"));
                //tulipHallSelect.Click();
                ////sanh Lotus
                //IWebElement lotusHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[5]/div/button"));
                //tulipHallSelect.Click();
                ////sanh Pense
                //IWebElement penseHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[6]/div/button"));
                //penseHallSelect.Click();
                ////sanh Violet
                //IWebElement violetHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[7]/div/button"));
                //violetHallSelect.Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }


        // Test Dat mon
        private void btn_testfoodorder_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login");

                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("abcd123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input"));
                loginButton.Click();

                IWebElement bookingButton = driver.FindElement(By.LinkText("Booking"));
                bookingButton.Click();

                // Tìm trường nhập ngày sinh
                IWebElement eventDate = driver.FindElement(By.Id("date"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", eventDate, "2024-01-29");

                SelectElement timeDropdown = new SelectElement(driver.FindElement(By.Id("type_day")));
                timeDropdown.SelectByText("affternoon");

                IWebElement tableField = driver.FindElement(By.Id("countTable"));
                tableField.SendKeys("25");

                IWebElement noteField = driver.FindElement(By.Id("note"));
                noteField.SendKeys("12g ");

                IWebElement hallSelectButton = driver.FindElement(By.XPath("//*[@id=\"wedding-hall\"]/button"));
                hallSelectButton.Click();

                //sanh rose
                IWebElement roseHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[1]/div/button"));
                roseHallSelect.Click();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
