﻿// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json.Serialization;

namespace Models;

internal class HealthResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}