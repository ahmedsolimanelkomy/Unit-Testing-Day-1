using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibaray_test
{
    public class BMWTest
    {
        // bool assert
        [Fact]
        public void IsStoppedVelocity0_true()
        {
            BMW bMW = new BMW();
            bMW.velocity = 0;
            bool Result = bMW.IsStopped();
            Assert.True(Result);
        }
        [Fact]
        public void IsStoppedVelocity10_false()
        {
            BMW bMW = new BMW();
            bMW.velocity = 10;
            bool Result = bMW.IsStopped();
            Assert.False(Result);
        }

        // Numeric Assert
        [Fact]
        public void IncreaseVelocity_valocity10Add20_30() {
            BMW bMW = new BMW();
            bMW.velocity = 10;
            bMW.IncreaseVelocity(20);
            Assert.Equal(30,bMW.velocity);
        }

        // String Assert
        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            BMW bMW = new BMW();
            bMW.drivingMode = DrivingMode.Stopped;
            string result
                 = bMW.GetDirection();
            Assert.Equal("Stopped", result);
        }

        // Reference Assert 
        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            BMW bMW = new BMW();
            Car car = bMW.GetMyCar();
            Assert.Same(bMW, car);
        }
        // Type Assert
        [Fact]
        public void GetMyCars_callFunction_SameTypes()
        {
            BMW bMW = new BMW();
            BMW bMW1 = new BMW();
            Assert.Equal(bMW, bMW1);
        }


    }
}
