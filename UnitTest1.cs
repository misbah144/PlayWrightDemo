/*using Microsoft.Playwright;

namespace PlayWrightDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        using var playwright = await Playwright.CreateAsync();
        await  using var browser  = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false});
        var page= await browser.NewPageAsync();
        await page.GotoAsync(url: "http://www.eaapp.somee.com");
        await page.ClickAsync(selector: "text=Login");
        //await page.ScreenshotAsync(new PageScreenshotOptions{Path = "test.png"});
        
        await page.FillAsync(selector: "#UserName", value:"admin");
        await page.FillAsync(selector: "#Password", value:"password");
        await page.ClickAsync(selector: "text=Log in");
        var isexist = await page.Locator(selector: "text=Employee Details").IsVisibleAsync();
        await page.ScreenshotAsync(new PageScreenshotOptions{Path = "test.png"});
        Assert.IsTrue(isexist);
        
        //Assert.Pass();
    }
}*/