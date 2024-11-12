using OrderProvider.Domain.Factories;
using OrderProvider.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProviderTests
{
    public class ResponseResultFactoryTests
    {
        [Fact]
        public void Success__ShouldReturn_True_AndStatus200()
        {
            // Act
            var result = ResponseResultFactory.Success(status: 201);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(201, result.Status);
        }
        [Fact]
        public void Faild__ShouldReturn__False_AndStatus400()
        {
            // Act
            var result = ResponseResultFactory.failed();

            // Assert
            Assert.False(result.Success);
            Assert.Equal(400, result.Status);
        }
        [Fact]
        public void Exists__Should_ReturnFalse_AndStatus409()
        {
            // Act
            var result = ResponseResultFactory.Exists();

            // Assert
            Assert.False(result.Success);
            Assert.Equal(409, result.Status);
        }

        [Fact]
        public void NotFound__Should_ReturnFalse_AndStatus404()
        {
            // Act
            var result = ResponseResultFactory.NotFound();

            // Assert
            Assert.IsAssignableFrom<ResponseResult>(result);
            Assert.False(result.Success);
            Assert.Equal(404, result.Status);
        }


    }
}
