using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaVirtual.UI.MVC.Controllers;
using System.Web.Mvc;
using LojaVirtual.Aplicacao.Interfaces;
using Moq;

namespace LojaVirtual.UI.MVC.Tests.Controllers
{
    [TestClass]
    public class CategoriasControllerTest
    {
        private Mock<IAppServiceCategorias> _mock;
        
        [TestMethod]
        public void Index()
        {
            //// Arrange
            //CategoriasController controller = new CategoriasController(_mock.Object);

            //// Act
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
        }
    }
}
