using System;

public static class PhoneNumber
{
    const string NEW_YORK_AREA_CODE = "212";
    const string FAKE_PREFIX = "555";
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber) =>
        (phoneNumber[..phoneNumber.IndexOf('-')] is NEW_YORK_AREA_CODE,
         phoneNumber[(phoneNumber.IndexOf('-') + 1)..phoneNumber.LastIndexOf('-')] is FAKE_PREFIX,
         phoneNumber[(phoneNumber.LastIndexOf('-') + 1)..]);

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) =>
        phoneNumberInfo.IsFake;
}
