﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shouldly
{
    [DebuggerStepThrough]
    [ShouldlyMethods]
    public static class ShouldBeNumericTestExtensions
    {
        public static void ShouldBe(this float actual, float expected, double tolerance)
        {
            ShouldBe(actual, expected, tolerance, () => null);
        }

        public static void ShouldBe(this float actual, float expected, double tolerance, string customMessage)
        {
            ShouldBe(actual, expected, tolerance, () => customMessage);
        }

        public static void ShouldBe(this float actual, float expected, double tolerance, Func<string> customMessage)
        {
            actual.AssertAwesomely(v => Is.Equal(v, expected, tolerance), actual, expected, tolerance, customMessage);
        }

        public static void ShouldBe(this IEnumerable<double> actual, IEnumerable<double> expected, double tolerance)
        {
            ShouldBe(actual, expected, tolerance, () => null);
        }

        public static void ShouldBe(this IEnumerable<double> actual, IEnumerable<double> expected, double tolerance, string customMessage)
        {
            ShouldBe(actual, expected, tolerance, () => customMessage);
        }

        public static void ShouldBe(this IEnumerable<double> actual, IEnumerable<double> expected, double tolerance, Func<string> customMessage)
        {
            actual.AssertAwesomely(v => Is.Equal(v, expected, tolerance), actual, expected, tolerance, customMessage);
        }

        public static void ShouldBe(this IEnumerable<float> actual, IEnumerable<float> expected, double tolerance)
        {
            ShouldBe(actual, expected, tolerance, () => null);
        }

        public static void ShouldBe(this IEnumerable<float> actual, IEnumerable<float> expected, double tolerance, string customMessage)
        {
            ShouldBe(actual, expected, tolerance, () => customMessage);
        }

        public static void ShouldBe(this IEnumerable<float> actual, IEnumerable<float> expected, double tolerance, Func<string> customMessage)
        {
            actual.AssertAwesomely(v => Is.Equal(v, expected, tolerance), actual, expected, tolerance, customMessage);
        }

        public static void ShouldBe(this double actual, double expected, double tolerance)
        {
            ShouldBe(actual, expected, tolerance, () => null);
        }

        public static void ShouldBe(this double actual, double expected, double tolerance, string customMessage)
        {
            ShouldBe(actual, expected, tolerance, () => customMessage);
        }

        public static void ShouldBe(this double actual, double expected, double tolerance, Func<string> customMessage)
        {
            actual.AssertAwesomely(v => Is.Equal(v, expected, tolerance), actual, expected, tolerance, customMessage);
        }

        public static void ShouldBe(this decimal actual, decimal expected, decimal tolerance)
        {
            ShouldBe(actual, expected, tolerance, () => null);
        }

        public static void ShouldBe(this decimal actual, decimal expected, decimal tolerance, string customMessage)
        {
            ShouldBe(actual, expected, tolerance, () => customMessage);
        }

        public static void ShouldBe(this decimal actual, decimal expected, decimal tolerance, Func<string> customMessage)
        {
            actual.AssertAwesomely(v => Is.Equal(v, expected, tolerance), actual, expected, tolerance, customMessage);
        } 
    }
}