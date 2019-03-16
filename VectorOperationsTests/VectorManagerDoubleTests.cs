﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorOperations;
using System.IO;
using System.Reflection;

namespace VectorOperationsTests {
    /// <summary>
    /// Unit tests of Vector<double> class.
    /// </summary>
    [TestClass]
    public class VectorManagerDoubleTests {
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Testing operation of adding vectors.
        /// </summary>
        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"D:\github\vector-operations\VectorOperationsTests\data.csv", 
            "data#csv", 
            DataAccessMethod.Sequential),
            DeploymentItem("data.csv")]
        public void Adding() {
            Vector<double> VECTOR_1 = new Vector<double>(
                Convert.ToDouble(TestContext.DataRow["a1"]),
                Convert.ToDouble(TestContext.DataRow["b1"]),
                Convert.ToDouble(TestContext.DataRow["c1"])
                );
            Vector<double> VECTOR_2 = new Vector<double>(
                Convert.ToDouble(TestContext.DataRow["a2"]),
                Convert.ToDouble(TestContext.DataRow["b2"]),
                Convert.ToDouble(TestContext.DataRow["c2"])
                );

            VectorManagerDouble OperationsDouble = new VectorManagerDouble();
            Vector<double> VECTOR_3 = OperationsDouble.Add(VECTOR_1, VECTOR_2);

            Assert.AreEqual(Convert.ToDouble(TestContext.DataRow["a3"]), VECTOR_3.x);
            Assert.AreEqual(Convert.ToDouble(TestContext.DataRow["b3"]), VECTOR_3.y);
            Assert.AreEqual(Convert.ToDouble(TestContext.DataRow["c3"]), VECTOR_3.z);
        }
        /*
        /// <summary>
        /// Testowanie operacji odejmowania wektorów.
        /// </summary>
        [TestMethod]
        public void Substracting() {
            Vector VECTOR_1 = new Vector(1, 2, 3);
            Vector VECTOR_2 = new Vector(4.5, 5.5, 7);

            Vector VECTOR_3 = VECTOR_1 - VECTOR_2;

            Assert.AreEqual(-3.5, VECTOR_3.X);
            Assert.AreEqual(-3.5, VECTOR_3.Y);
            Assert.AreEqual(-4, VECTOR_3.Z);
        }

        /// <summary>
        /// Testowanie operacji mnożenia wektora przez skalar (1 - liczba całkowita).
        /// </summary>
        [TestMethod]
        public void Multiplying_1() {
            //poprawic wartosci!
            Vector VECTOR_1 = new Vector(1, 2, 3);
            double value = 5.34;

            Vector VECTOR_3 = value * VECTOR_1;

            Assert.AreEqual(5.34, VECTOR_3.X);
            Assert.AreEqual(10.68, VECTOR_3.Y);
            Assert.AreEqual(16.02, VECTOR_3.Z);
        }

        /// <summary>
        /// Testowanie operacji mnożenia wektorów (2 - liczba zmiennoprzecinkowa).
        /// </summary>
        [TestMethod]
        public void Multiplying_2() {
            Vector VECTOR_1 = new Vector(1, 2, 3);
            double value = 5.34;

            Vector VECTOR_3 = VECTOR_1 * value;

            Assert.AreEqual(5.34, VECTOR_3.X);
            Assert.AreEqual(10.68, VECTOR_3.Y);
            Assert.AreEqual(16.02, VECTOR_3.Z);
        }

        /// <summary>
        /// Testowanie konstruktora (1).
        /// </summary>
        [TestMethod]
        public void CheckingConstructor_1() {
            Vector vector = new Vector();

            Assert.AreEqual(0, vector.X);
            Assert.AreEqual(0, vector.Y);
            Assert.AreEqual(0, vector.Z);
        }

        /// <summary>
        /// Testowanie konstruktora (2).
        /// </summary>
        [TestMethod]
        public void CheckingConstructor_2() {
            Vector vector = new Vector(1.5);

            Assert.AreEqual(1.5, vector.X);
            Assert.AreEqual(0, vector.Y);
            Assert.AreEqual(0, vector.Z);
        }

        /// <summary>
        /// Testowanie konstruktora (3).
        /// </summary>
        [TestMethod]
        public void CheckingConstructor_3() {
            Vector vector = new Vector(1.5, 6.6);

            Assert.AreEqual(1.5, vector.X);
            Assert.AreEqual(6.6, vector.Y);
            Assert.AreEqual(0, vector.Z);
        }

        /// <summary>
        /// Testowanie kopiowania głębokiego.
        /// </summary>
        [TestMethod]
        public void CopyingVector() {
            Vector VECTOR_1 = new Vector(1, 2, 3);
            Vector VECTOR_2 = new Vector(VECTOR_1);

            Assert.AreNotSame(VECTOR_1, VECTOR_2);
        }*/
    }
}
