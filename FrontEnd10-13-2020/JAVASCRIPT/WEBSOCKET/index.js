const http=require("http");

const httpserver=http.createServer((req,res) => {

    console.log("we have received a request");//first call of request will come here 

    httpserver.listen(8080,() => console.log("my server is listening"))
})