using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumBasic.Core;

public class AdvancedDriver                       //запуск веб-браузера с определенными свойствами
{
    private string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    public IWebDriver GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--incognito");   //запустить хром в приватном режиме
        chromeOptions.AddArguments("--disable-gpu"); //отключить графический процессор (н-р, внеш.видеокарту, чтобы приблизить работу нашего браузера к большинству польз-й))
        chromeOptions.AddArguments("--disable-extensions");  //отключить всякие дополнения=обезличить браузер
        //chromeOptions.AddArguments("--headless");   //режим без ui-ной части

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);  //устанавливаем настройки логирования, чтоб отловить консольные ошибки
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        return new ChromeDriver(basePath + @"/Resources/", chromeOptions);  //после запускаем браузер с настроенными chromeOptions
    }

    public IWebDriver GetFirefoxDriver()
    {
        var mimeTypes =
            "image/png,image/gif,image/jpeg,image/pjpeg,application/pdf,text/csv,application/vnd.ms-excel," +
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" +
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        var ffOptions = new FirefoxOptions();
        var profile = new FirefoxProfile();

        profile.SetPreference("browser.download.folderList", 2);
        profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", mimeTypes);
        profile.SetPreference("browser.helperApps.neverAsk.openFile", mimeTypes);
        ffOptions.Profile = profile;

        ffOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        ffOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        return new FirefoxDriver(ffOptions);
    }
}
