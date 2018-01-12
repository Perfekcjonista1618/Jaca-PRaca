var qs = require('querystring');
var strona = 'powitanie=witaj&imie=xxxxx&nazwisko=yyyyyy';
var message = qs.parse(strona);
console.log(message.powitanie, message.imie, message.nazwisko);