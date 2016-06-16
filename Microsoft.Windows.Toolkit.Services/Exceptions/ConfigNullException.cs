﻿// *********************************************************
//  Copyright (c) Microsoft. All rights reserved.
//  This code is licensed under the MIT License (MIT).
//  THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
//  IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
//  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
//  TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH 
//  THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// *********************************************************
using System;

namespace Microsoft.Windows.Toolkit.Services.Exceptions
{
    public class ConfigNullException : Exception
    {
        public ConfigNullException()
        {
        }

        public ConfigNullException(string message) 
            : base(message)
        {
        }

        public ConfigNullException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}