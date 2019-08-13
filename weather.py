
var unirest = require("unirest");

var req = unirest("GET", "https://community-open-weather-map.p.rapidapi.com/weather");

req.query({
	"callback": "test",
	"id": "2172797",
	"units": "\"metric\" or \"imperial\"",
	"mode": "xml, html",
	"q": "London,uk"
});

req.headers({
	"x-rapidapi-host": "community-open-weather-map.p.rapidapi.com",
	"x-rapidapi-key": "23876321f5msha2807cb302e400fp108e5djsn4bcd7ff8177f"
});


req.end(function (res) {
	if (res.error) throw new Error(res.error);

	console.log(res.body);
});
{12 items
"coord":{2 items
"lon":-0.13
"lat":51.51
}
"sys":{4 items
"message":0.0223
"country":"GB"
"sunrise":1398055845
"sunset":1398107249
}
"weather":[1 item
0:{...}4 items
]
"base":"cmc stations"
"main":{5 items
"temp":290.04
"humidity":70
"pressure":1003
"temp_min":287.04
"temp_max":293.15
}
"wind":{3 items
"speed":0.51
"gust":3.6
"deg":93
}
"rain":{1 item
"1h":1.02
}
"clouds":{1 item
"all":56
}
"dt":1398100214
"id":2643743
"name":"London"
"cod":200
}
