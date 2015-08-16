﻿/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2015 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minio.Errors
{
    public class DataSizeMismatchException : ClientException
    {
        public DataSizeMismatchException(string bucket, string key, long userSpecifiedSize, long actualReadSize)
        {
            this.Bucket = bucket;
            this.Key = key;
            this.UserSpecifiedSize = userSpecifiedSize;
            this.ActualReadSize = actualReadSize;
        }
        public DataSizeMismatchException()
            : this(null, null, 0, 0)
        {

        }
        public string Bucket { get; private set; }
        public string Key { get; private set; }
        public long UserSpecifiedSize { get; private set; }
        public long ActualReadSize { get; private set; }
    }
}
