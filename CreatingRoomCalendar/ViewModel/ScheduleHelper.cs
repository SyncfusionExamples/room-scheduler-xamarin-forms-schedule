﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ScheduleGettingStarted
{
    /// <summary>
    /// Time Zone Collection class
    /// </summary>
    public static class AppointmentEditorHelper
    {
        /// <summary>
        /// Gets or sets time zone list
        /// </summary>
        public static IList TimeZoneList { get; set; } = new List<string>()
        {
                "Default",
                "AUS Central Standard Time",
                "AUS Eastern Standard Time",
                "Afghanistan Standard Time",
                "Alaskan Standard Time",
                "Arab Standard Time",
                "Arabian Standard Time",
                "Arabic Standard Time",
                "Argentina Standard Time",
                "Atlantic Standard Time",
                "Azerbaijan Standard Time",
                "Azores Standard Time",
                "Bahia Standard Time",
                "Bangladesh Standard Time",
                "Belarus Standard Time",
                "Canada Central Standard Time",
                "Cape Verde Standard Time",
                "Caucasus Standard Time",
                "Cen. Australia Standard Time",
                "Central America Standard Time",
                "Central Asia Standard Time",
                "Central Brazilian Standard Time",
                "Central Europe Standard Time",
                "Central European Standard Time",
                "Central Pacific Standard Time",
                "Central Standard Time",
                "China Standard Time",
                "Dateline Standard Time",
                "E. Africa Standard Time",
                "E. Australia Standard Time",
                "E. South America Standard Time",
                "Eastern Standard Time",
                "Egypt Standard Time",
                "Ekaterinburg Standard Time",
                "FLE Standard Time",
                "Fiji Standard Time",
                "GMT Standard Time",
                "GTB Standard Time",
                "Georgian Standard Time",
                "Greenland Standard Time",
                "Greenwich Standard Time",
                "Hawaiian Standard Time",
                "India Standard Time",
                "Iran Standard Time",
                "Israel Standard Time",
                "Jordan Standard Time",
                "Kaliningrad Standard Time",
                "Korea Standard Time",
                "Libya Standard Time",
                "Line Islands Standard Time",
                "Magadan Standard Time",
                "Mauritius Standard Time",
                "Middle East Standard Time",
                "Montevideo Standard Time",
                "Morocco Standard Time",
                "Mountain Standard Time",
                "Mountain Standard Time (Mexico)",
                "Myanmar Standard Time",
                "N. Central Asia Standard Time",
                "Namibia Standard Time",
                "Nepal Standard Time",
                "New Zealand Standard Time",
                "Newfoundland Standard Time",
                "North Asia East Standard Time",
                "North Asia Standard Time",
                "Pacific SA Standard Time",
                "Pacific Standard Time",
                "Pacific Standard Time (Mexico)",
                "Pakistan Standard Time",
                "Paraguay Standard Time",
                "Romance Standard Time",
                "Russia Time Zone 10",
                "Russia Time Zone 11",
                "Russia Time Zone 3",
                "Russian Standard Time",
                "SA Eastern Standard Time",
                "SA Pacific Standard Time",
                "SA Western Standard Time",
                "SE Asia Standard Time",
                "Samoa Standard Time",
                "Singapore Standard Time",
                "South Africa Standard Time",
                "Sri Lanka Standard Time",
                "Syria Standard Time",
                "Taipei Standard Time",
                "Tasmania Standard Time",
                "Tokyo Standard Time",
                "Tonga Standard Time",
                "Turkey Standard Time",
                "US Eastern Standard Time",
                "US Mountain Standard Time",
                "UTC",
                "UTC+12",
                "UTC-02",
                "UTC-11",
                "Ulaanbaatar Standard Time",
                "Venezuela Standard Time",
                "Vladivostok Standard Time",
                "W. Australia Standard Time",
                "W. Central Africa Standard Time",
                "W. Europe Standard Time",
                "West Asia Standard Time",
                "West Pacific Standard Time",
                 "Yakutsk Standard Time"
        };

        public static List<MeetingRoomInfo> Resources { get; set; } = new List<MeetingRoomInfo>()
        {
            new MeetingRoomInfo(){Name="Jammy",Id="5001",Color= Color.FromHex("#FF339933")},
            new MeetingRoomInfo(){Name="Tweety",Id="5002",Color= Color.FromHex("#FF00ABA9")},
            new MeetingRoomInfo(){Name="Nestle",Id="5003",Color= Color.FromHex("#FFE671B8")},
            new MeetingRoomInfo(){Name="Phoneix",Id="5004",Color= Color.FromHex("#FF1BA1E2")},
            new MeetingRoomInfo(){Name="Mission",Id="5005",Color= Color.FromHex("#FFD80073")},
            new MeetingRoomInfo(){Name="Emilia",Id="5006",Color= Color.FromHex("#FFA2C139")}
        };

        public static ObservableCollection<Meeting> Appointments { get; set; }
    }
}
