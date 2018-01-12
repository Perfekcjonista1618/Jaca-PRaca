var http = require('http');
var querystring = require('querystring')
const postData = querystring.stringify({
    'msg': 'Hello World!'
  });
 var options= { 
     hostname: 'www.google.com',
     path: '/upload', 
     port: '80', 
     method: 'POST', 
     headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
        'Content-Length': Buffer.byteLength(postData)
      }}; 

var req = http.request(options,function(response){
    var str=''; 
    response.on('data',function (chunk){ str+=chunk; });
    response.on('end',function(){console.log(str); });
    });
    req.write(postData);
req.end();