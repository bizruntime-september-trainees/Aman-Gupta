//node js receiveing the message
//send the message back to client
var server=require('ws').Server;
var s= new server({port:5001});

s.on('connection',function(ws){
    ws.on('message',function(message){
            console.log("EReceived:"+message);
        ws.send("from server: "+message);
        });

});