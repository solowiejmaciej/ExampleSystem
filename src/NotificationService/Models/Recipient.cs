﻿namespace NotificationService.Models;

public class Recipient
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string DeviceId { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; }
}