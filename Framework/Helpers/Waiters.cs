using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Helpers
{
    public class Waiters
    {
        public static void WaitForPageToLoad(IWebDriver webDriver)
        {
            TimeSpan timeout = new TimeSpan(0, 0, 30);
            WebDriverWait wait = new WebDriverWait(webDriver, timeout);

            IJavaScriptExecutor javascript = webDriver as IJavaScriptExecutor;
            if (javascript == null)
                throw new ArgumentException("driver", "Driver must support javascript execution");

            wait.Until((d) =>
            {
                try
                {
                    string readyState = javascript.ExecuteScript(
                        "if (document.readyState) return document.readyState;").ToString();
                    return readyState.ToLower() == "complete";
                }
                catch (InvalidOperationException e)
                {
                    //Window is no longer available
                    return e.Message.ToLower().Contains("unable to get browser");
                }
                catch (WebDriverException e)
                {
                    //Browser is no longer available
                    return e.Message.ToLower().Contains("unable to connect");
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        private static IWebDriver webDriver;

        public static void WaitForPageToLoad2()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) webDriver;
            int timeoutSec = 60;
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        public static void Wait()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public void Wait2()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
            IJavaScriptExecutor js = (IJavaScriptExecutor) webDriver;
            wait.Until(wd => js.ExecuteScript("return document.readyState === 'complete';"));
        }
        
        
    }

}
