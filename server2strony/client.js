var http = require('http'); 
var options = { 
    hostname: 'localhost', 
    path: '/nowa.html', 
    port: '8080' }; 
    
    function handleResponse(response){ 
        var str=''; 
        response.on('data',function (chunk) { 
            str+=chunk; 
        });
        response.on('end',function(){ console.log(str); }); 
    };
var req = http.request(options,function(response){ 
    handleResponse(response); 
}).end();