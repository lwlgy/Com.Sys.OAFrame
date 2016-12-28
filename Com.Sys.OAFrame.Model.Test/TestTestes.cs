using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Sys.OAFrame.Model.Test
{
    [TestClass]
    public class TestTestes
    {
        TestContext db = new TestContext();
        [TestMethod]
        public void TestCreateDataBase()
        {
            db.Testes.RemoveRange(db.Testes);
            db.Testes.Add(new Entities.Test {
                Id = Guid.NewGuid(),
                Name = "张三",
                Pwd = "123",
                Gender = true,
                Birthday = DateTime.Now.AddYears(-15),
                Remark = "这是张三的备注"
            });
            db.Testes.Add(new Entities.Test
            {
                Id = Guid.NewGuid(),
                Name = "李四",
                Pwd = "12345",
                Gender = true,
                Birthday = DateTime.Now.AddYears(-10),
                Remark = "这是李四的备注"
            });
            db.SaveChanges();

            var count = db.Testes.Count();
            Assert.AreEqual(2, count);
        }
    }
}
