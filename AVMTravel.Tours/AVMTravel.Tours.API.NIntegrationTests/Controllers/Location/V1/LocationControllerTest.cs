using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using AVMTravel.Tours.API.Controllers.Location.V1;
using AVMTravel.Tours.API.NIntegrationTests.Common;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace AVMTravel.Tours.API.NIntegrationTests.Controllers.Location.V1
{
    [TestFixture, Category("IntegrationTests")]
    public class LocationControllerTest : DynamicTestInjectionHost
    {        
        [SetUp]
        public void SetUp()
        {
        }

        [Test(Description = "Should_be_valid")]
        public async Task Should_be_valid()
        {
            //Arrange
            var controller = GetService<LocationController>(DynamicMocks.ConfigureLocationController);

            //Act
            CreateLocationRequest request = new()
            {
                Name = "Salta",
            };

            var postResponse = await controller.CreateLocationAsync(request);

            if (postResponse is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value is CreateLocationResult createLocationResult)
                {
                    var getResponse = await controller.GetLocationByIdAsync(createLocationResult.Id);
                    if (getResponse is OkObjectResult okGetObjectResult)
                    {
                        if (okGetObjectResult.Value is GetByIdLocationResult getByIdLocationResult)
                        {
                            // Assert
                            Assert.IsNotNull(getByIdLocationResult);
                            Assert.AreEqual(request.Name, getByIdLocationResult.Name);
                        }
                    }                       
                }
            }
        }
    }
}
