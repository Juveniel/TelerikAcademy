namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
            // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Details_ShouldThrowException_WhenCarIsNull()
        {   
            //Arrange     
            var mockedCarRepository = new Mock<ICarsRepository>();
            mockedCarRepository.Setup(c => c.GetById(It.IsAny<int>())).Returns((Car) null);

            var carController = new CarsController(mockedCarRepository.Object);

            //Act
            var result = carController.Details(1);
        }
     

        [TestMethod]
        public void Search_ShouldReturnViewCorrectly()
        {
            //Arrange
            var mockedCarRepository = new Mock<ICarsRepository>();
            var mockedCar = new Mock<Car>();

            mockedCarRepository.Setup(c => c.Search(It.IsAny<string>())).Returns(new List<Car>() { mockedCar.Object});

            var carController = new CarsController(mockedCarRepository.Object);

            //Act
            var result = carController.Search("");

            //Assert
            mockedCarRepository.Verify(mock => mock.Search(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_ShouldThrowException_WhenParameterIsInvalid()
        {
            //Arrange
            const string invalidParameter = "asdadsdas";
            var carController = new CarsController();

            //Act & assert
            carController.Sort(invalidParameter);
        }

        [TestMethod]
        public void Sort_MakeParameterCallShouldExecuteTheCorrectSortingMethod()
        {
            //Arrange
            const string sortingParam = "make";
            var mockedCarRepository = new Mock<ICarsRepository>();
            mockedCarRepository.Setup(c => c.SortedByMake()).Returns(new List<Car>() {});

            var carController = new CarsController(mockedCarRepository.Object);

            //Act
            var sort = carController.Sort(sortingParam);

            //Assert
            mockedCarRepository.Verify(mock => mock.SortedByMake(), Times.Once);
        }

        [TestMethod]
        public void Sort_YearParameterCallShouldExecuteTheCorrectSortingMethod()
        {
            //Arrange
            const string sortingParam = "year";
            var mockedCarRepository = new Mock<ICarsRepository>();
            mockedCarRepository.Setup(c => c.SortedByYear()).Returns(new List<Car>() {});

            var carController = new CarsController(mockedCarRepository.Object);

            //Act
            var sort = carController.Sort(sortingParam);

            //Assert
            mockedCarRepository.Verify(mock => mock.SortedByYear(), Times.Once);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
