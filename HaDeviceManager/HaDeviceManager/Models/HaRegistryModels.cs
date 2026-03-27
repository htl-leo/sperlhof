using System.Text.Json.Serialization;

namespace HaDeviceManager.Models;

public class HaDevice
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("name_by_user")]
    public string? NameByUser { get; set; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; set; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; set; }

    [JsonPropertyName("entry_type")]
    public string? EntryType { get; set; }

    public string DisplayName => NameByUser ?? Name ?? Id;
}

public class HaEntityRegistryEntry
{
    [JsonPropertyName("entity_id")]
    public string EntityId { get; set; } = "";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    [JsonPropertyName("device_id")]
    public string? DeviceId { get; set; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; set; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; set; }

    [JsonPropertyName("hidden_by")]
    public string? HiddenBy { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    public string Domain => EntityId.Contains('.') ? EntityId.Split('.')[0] : EntityId;
    public string DisplayName => Name ?? EntityId;
}
