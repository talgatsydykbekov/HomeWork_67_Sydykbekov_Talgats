using System.Text;
using WebApplication3.Services;
using Xunit;

namespace les67.Tests;

public class PasswordHasherTests
{
    [Fact]
    public void Md5HashPasswordTest()
    {
        var hasher = new PasswordHasher();
        var pwd = hasher.Md5HashPassword("qwerty123");
        Assert.Equal(16, pwd.Length);
        Assert.True(pwd != null);
         pwd[0] = 63;
         pwd[1] = 241;
         pwd[2] = 241;
         pwd[3] = 241;
        Assert.Equal(63, pwd[0]);
        pwd[4] = 240;
        Assert.Equal(240, pwd[4]);
         pwd[0] = 163;
         pwd[5] = 241;
         pwd[6] = 241;
         pwd[7] = 241;
         pwd[8] = 241;
         pwd[9] = 241;
        Assert.Equal(2331, pwd.Sum(p => p));
        //

        Assert.Contains("0a7ac", hasher.ToHex(pwd));
        Assert.EndsWith("4b8b1", hasher.ToHex(pwd));
        Assert.Equal(32, hasher.ToHex(pwd).Length);
        Assert.Equal('0', hasher.ToHex(pwd)[3]);
    }
}