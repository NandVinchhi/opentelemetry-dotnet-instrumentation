// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

namespace OpenTelemetry.AutoInstrumentation;

internal static class ClrNames
{
    public const string Ignore = "_";

    public const string Void = "System.Void";
    public const string Object = "System.Object";
    public const string Bool = "System.Boolean";
    public const string String = "System.String";

    public const string SByte = "System.SByte";
    public const string Byte = "System.Byte";

    public const string Int16 = "System.Int16";
    public const string Int32 = "System.Int32";
    public const string Int64 = "System.Int64";

    public const string UInt16 = "System.UInt16";
    public const string UInt32 = "System.UInt32";
    public const string UInt64 = "System.UInt64";

    public const string Stream = "System.IO.Stream";

    public const string Task = "System.Threading.Tasks.Task";
    public const string CancellationToken = "System.Threading.CancellationToken";

    // ReSharper disable once InconsistentNaming
    public const string IAsyncResult = "System.IAsyncResult";
    public const string AsyncCallback = "System.AsyncCallback";

    public const string HttpRequestMessage = "System.Net.Http.HttpRequestMessage";
    public const string HttpResponseMessage = "System.Net.Http.HttpResponseMessage";
    public const string HttpResponseMessageTask = "System.Threading.Tasks.Task`1<System.Net.Http.HttpResponseMessage>";

    public const string GenericTask = "System.Threading.Tasks.Task`1";
    public const string GenericTaskWithGenericClassParameter = "System.Threading.Tasks.Task`1[!0]";
    public const string GenericParameterTask = "System.Threading.Tasks.Task`1<T>";
    public const string IgnoreGenericTask = "System.Threading.Tasks.Task`1<_>";
    public const string Int32Task = "System.Threading.Tasks.Task`1<System.Int32>";
    public const string ObjectTask = "System.Threading.Tasks.Task`1<System.Object>";
}
