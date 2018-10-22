using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SegundoParcial.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests<T>: IDisposable, IRepository<T> where T : class
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest(T Metas)
        {
            {
                bool paso = false;
                try
                {
                    if (_db.Set<T>().Add(entity) != null)
                        paso = _db.SaveChanges() > 0;
                }
                catch (Exception)
                { throw; }
                return paso;
            }
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}