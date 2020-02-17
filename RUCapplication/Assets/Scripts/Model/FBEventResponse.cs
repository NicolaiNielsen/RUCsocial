using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System;
using Newtonsoft.Json;
using System.IO;


public class Location
{
    public string city { get; set; }
    public string country { get; set; }
    public double latitude { get; set; }
    public string located_in { get; set; }
    public double longitude { get; set; }
    public string street { get; set; }
    public string zip { get; set; }
}

public class Place
{
    public string name { get; set; }
    public Location location { get; set; }
    public string id { get; set; }
}

public class Datum
{
    public string description { get; set; }
    public DateTime end_time { get; set; }
    public string name { get; set; }
    public Place place { get; set; }
    public DateTime start_time { get; set; }
    public string id { get; set; }
    public string rsvp_status { get; set; }
}

public class Cursors
{
    public string before { get; set; }
    public string after { get; set; }
}

public class Paging
{
    public Cursors cursors { get; set; }
}

public class Events
{
    public List<Datum> Data { get; set; }
    public Paging paging { get; set; }
}

public class RootObject
{
    public Events events { get; set; }
    public string id { get; set; }
}
