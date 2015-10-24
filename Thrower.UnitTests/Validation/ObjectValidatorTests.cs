﻿// File name: ObjectValidatorTests.cs
// 
// Author(s): Alessio Parma <alessio.parma@gmail.com>
// 
// The MIT License (MIT)
// 
// Copyright (c) 2013-2016 Alessio Parma <alessio.parma@gmail.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using NUnit.Framework;
using PommaLabs.Thrower.Validation;
using System.Collections.Generic;
using System.Linq;

namespace PommaLabs.Thrower.UnitTests.Validation
{
    sealed class ObjectValidatorTests : AbstractTests
    {
        [Test]
        public void Validate_TestClass()
        {
            IList<ValidationError> validationErrors;
            var result = ObjectValidator.Validate(new TestClass(), out validationErrors);

            Assert.IsFalse(result);
            Assert.AreEqual(1, validationErrors.Count);
            Assert.AreEqual(1, validationErrors.Count(ve => ve.Path == nameof(TestClass.NullableBooleanThatShouldBeValidated)));
        }

        public sealed class TestClass
        {
            public bool BooleanThatShouldNotBeValidated { get; set; }

            [Validate(Required = true)]
            public bool BooleanThatShouldBeValidated { get; set; }

            [Validate(Required = true)]
            public bool? NullableBooleanThatShouldBeValidated { get; set; } = null;
        }
    }
}
