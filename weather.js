
var unirest = require("unirest");

//var req = unirest("GET", "https://community-open-weather-map.p.rapidapi.com/weather");
var req = unirest.get('https://community-open-weather-map.p.rapidapi.com/weather').type('json');

req.query({
	//"callback": "test",
	"id": "2172797",
	"units": "\"imperial\"",
	"mode": "xml, html",
	"q": "Beijing, CN",
});

req.headers({
	"x-rapidapi-host": "community-open-weather-map.p.rapidapi.com",
	"x-rapidapi-key": "23876321f5msha2807cb302e400fp108e5djsn4bcd7ff8177f"
});



req.end(function (res) {
	if (res.error) throw new Error(res.error);
			var data = res.body;
			console.log(data['main'].temp_min);
			console.log(data['main'].temp_max);
});
function load(){
  var url="https://community-open-weather-map.p.rapidapi.com/weather";
  var title="";
  var Request=new XMLHttpRequest();
  Request.open('GET',url, false);
  Request.send();


  if(Request.readyState!=4 ||  Request.status!= 200 || Request.responseText===""){
  window.console.error("Request had an error");
  return;
  }
  var information=JSON.parse(Request.responseText);
  for (var i=0;i<9;i++){
    var title= information.main[0].temp;
    console.log(title);
    // var para=document.createElement("P");
    // para.innerHTML=title;
    // document.body.appendChild(para);

  }
}
