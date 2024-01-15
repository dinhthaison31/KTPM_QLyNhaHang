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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;

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
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login"); 

                // Tìm và click vào phần tử để mở form đăng nhập (ví dụ: button hoặc link)
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input")); 
                loginButton.Click();

                // Nhập thông tin đăng nhập (ví dụ: tên đăng nhập và mật khẩu)
                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("addmin123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                //Đóng màn hình đen khi chạy chương trình
                ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
                chrome.HideCommandPromptWindow = true;

                // Submit form để đăng nhập
                IWebElement submitButton = driver.FindElement(By.XPath("//input[@type='submit']")); 
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
                // Điều hướng đến trang đăng ký người dùng của trang web
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/register"); // Thay thế bằng URL của trang đăng ký nhân viên

                // Test case 1  
                // Điền thông tin đăng ký
                driver.FindElement(By.Id("email")).SendKeys("addmin123@gmail.com");
                driver.FindElement(By.Id("name")).SendKeys("manhcuonga3");
                driver.FindElement(By.Id("phone")).SendKeys("0923226323");
                // Tìm trường nhập ngày sinh
                IWebElement birthDayInput = driver.FindElement(By.Id("birth-day"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", birthDayInput, "2005-09-19");

                //  driver.FindElement(By.Id("birth-day")).SendKeys("20-Oct-2001");


                driver.FindElement(By.Id("password")).SendKeys("Admin@123");
                driver.FindElement(By.Id("confirmPassword")).SendKeys("Admin@123");

                // Upload ảnh (đường dẫn file ảnh cần thay đổi theo đường dẫn thực tế)
                string imagePath = @"C:\Users\nguye\Downloads\415939203_332048676296612_3045788807400134481_n.jpg";
                if (File.Exists(imagePath))
                {
                    driver.FindElement(By.Id("imageId")).SendKeys(imagePath);
                }


                IWebElement registerButton = driver.FindElement(By.XPath("//*[@id=\"user\"]/input"));
                registerButton.Click();
                MessageBox.Show("Đăng ký người dùng thành công!");
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

                // Tìm trường nhập ngày 
                IWebElement eventDate = driver.FindElement(By.Id("date"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", eventDate, "2024-01-29");
                // Chọn thời gian trong ngày 
                SelectElement timeDropdown = new SelectElement(driver.FindElement(By.Id("type_day")));
                timeDropdown.SelectByText("affternoon");
                // Nhập số bàn
                IWebElement tableField = driver.FindElement(By.Id("countTable"));
                tableField.SendKeys("35");
                // Ghi chú
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
                //Thời gian trong ngày
                SelectElement timeDropdown = new SelectElement(driver.FindElement(By.Id("type_day")));
                timeDropdown.SelectByText("affternoon");
                // Số bàn muốn đặt
                IWebElement tableField = driver.FindElement(By.Id("countTable"));
                tableField.SendKeys("25");
                // Ghi chú
                IWebElement noteField = driver.FindElement(By.Id("note"));
                noteField.SendKeys("12g ");

                IWebElement hallSelectButton = driver.FindElement(By.XPath("//*[@id=\"wedding-hall\"]/button"));
                hallSelectButton.Click();

                //sanh rose
                IWebElement roseHallSelect = driver.FindElement(By.XPath("//*[@id=\"exampleModal\"]/div/div/div[2]/div[1]/div/button"));
                roseHallSelect.Click();
                
                // Chọn món bất kì, thay đổi tên biến, đường dẫn xpath, số lần click trong vòng lặp sau đó copy paste
                // Viết thêm nếu muốn chọn thêm những món khác
                //IWebElement randomDishes = driver.FindElement(By.XPath(""));
                //for (int i = 0; i < 5; i++)
                //{
                //    randomDishes.Click();
                //}


                // VD: Chọn món cá gì đó
                IWebElement monchinhmotDishes = driver.FindElement(By.XPath("//*[@id=\"btn1\"]/button"));
                for (int i = 0; i < 3; i++)
                {
                    monchinhmotDishes.Click();
                }
                


                // Nhấn nút tiếp tục để tiến hành thanh toán
                //IWebElement continueButton = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div/div[1]/a"));
                //continueButton.Click();

                IWebElement continueButton = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div/div[1]/a"));
                driver.Navigate().Refresh();
                continueButton = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div/div[1]/a"));
                continueButton.Click();

                // Tiến hành thanh toán chọn 1 trong 2 options dưới đây để chạy
                // Thanh toán bằng MOMO
                IWebElement momoPayment = driver.FindElement(By.XPath(""));
                if (!momoPayment.Selected)
                {
                    momoPayment.Click();
                }
                //Thanh toán bằng tiền mặt
                //IWebElement cashPayment = driver.FindElement(By.XPath(""));
                //if (!cashPayment.Selected)
                //{
                //    cashPayment.Click();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

      
        //Test Thông tin cá nhân
        private void btn_TestProfile_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login");

                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("abcd123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input"));
                loginButton.Click();

                IWebElement avatarDropdown = driver.FindElement(By.XPath("//*[@id=\"mynavbar\"]/ul[2]/li[2]/a"));
                avatarDropdown.Click();

                IWebElement profileLink = driver.FindElement(By.XPath("//*[@id=\"mynavbar\"]/ul[2]/li[2]/ul/li[1]/a"));
                profileLink.Click();
                //Tên
                IWebElement renameField = driver.FindElement(By.Id("name"));
                renameField.Clear();
                renameField.SendKeys("thai son test 1");
                // Số điện thoại
                IWebElement phoneField = driver.FindElement(By.XPath("//*[@id=\"mobile\"]"));
                phoneField.Clear();
                phoneField.SendKeys("0908070605");
              
                // Tìm trường nhập ngày sinh
               IWebElement birthdayDate = driver.FindElement(By.Id("birthday"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", birthdayDate, "2002-12-01");

                

                IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"profileUser\"]/input[2]"));
                saveButton.Click();
            }
            catch 
                (Exception ex)
            {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }

        }

        // Test Nhân Viên
        private void btn_TestCreateStaff_Click_1(object sender, EventArgs e)
        {

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login");

                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("abc123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input"));
                loginButton.Click();

                IWebElement staffmanageButton = driver.FindElement(By.XPath("//*[@id=\"mynavbar\"]/ul[1]/li[5]/a/b"));
                staffmanageButton.Click();

                IWebElement addstaffButton = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/table/thead/tr[1]/th[2]/button"));
                addstaffButton.Click();

                IWebElement namestaffField = driver.FindElement(By.Id("nameStaff"));
                namestaffField.SendKeys("manhcuong a 1");

                // Tìm trường nhập ngày sinh
                IWebElement birthdaystaffDate = driver.FindElement(By.Id("birthdayStaff"));
                // Sử dụng JavaScript để thiết lập giá trị cho trường ngày
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = arguments[1];", birthdaystaffDate, "2001-01-24");

                IWebElement phonestaffField = driver.FindElement(By.XPath("//*[@id=\"mobileStaff\"]"));
                phonestaffField.SendKeys("0906440088");

                IWebElement emailstaffField = driver.FindElement(By.Id("emailStaff"));
                emailstaffField.SendKeys("abb123@gmail.com");

                IWebElement savestaffButton = driver.FindElement(By.XPath("//*[@id=\"newStaff\"]/div[3]/button[2]"));
                savestaffButton.Click();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }


        }

        // Test Quan ly dich vu
        private void btn_TestServices_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            try {
                driver.Navigate().GoToUrl("http://localhost:8080/QuanLyNhaHang/login");

                IWebElement usernameField = driver.FindElement(By.Id("email"));
                usernameField.SendKeys("abc123@gmail.com");

                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("Admin@123");

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/form/input"));
                loginButton.Click();

                IWebElement servicemanageButton = driver.FindElement(By.XPath("//*[@id=\"mynavbar\"]/ul[1]/li[4]/a"));
                servicemanageButton.Click();
                // Them dịch vụ
                IWebElement addserviceButton = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/button"));
                addserviceButton.Click();
                //Thêm thông tin của dịch vụ
                //IWebElement nameserviceField = driver.FindElement(By.Id("nameService"));
                //nameserviceField.SendKeys("Bóng bay");

                //IWebElement servicepriceField = driver.FindElement(By.Id("price"));
                //servicepriceField.Clear();
                //servicepriceField.SendKeys("1000");

                //IWebElement servicedesField = driver.FindElement(By.Id("describe"));
                //servicedesField.SendKeys("Thổi bóng bay");

                //Upload ảnh(đường dẫn file ảnh cần thay đổi theo đường dẫn thực tế)
                //string imagePath = @"C:\Users\nguye\Downloads\36961409-quả-bóng-màu-đỏ-bị-cô-lập-trên-nền-trắng.jpg";
                //if (File.Exists(imagePath))
                //{
                //    driver.FindElement(By.Id("imageUpload")).SendKeys(imagePath);
                //}

                IWebElement saveserviceButton = driver.FindElement(By.XPath("//*[@id=\"newService\"]/div[3]/button[2]"));
                saveserviceButton.Click();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
