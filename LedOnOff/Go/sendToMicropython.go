package main

import (
	"net"
	"net/http"
)

func main() {

	http.HandleFunc("/", func(res http.ResponseWriter, req *http.Request) {
		template := `
	<!DOCTYPE html>
	<html lang="en">
	<head>
	<meta charset="UTF-8">
	<title>Led ON/OFF</title>
	</head>
	<body>
	<a href="#" onclick="on()"><h1>ON</h1></a>
	<br>
	<a href="#" onclick="off()"><h1>OFF</h1></a>
	<script>
		var on = () => fetch("/on", {method: "GET"}).then(res => res );
		var off = () => fetch("/off", {method: "GET"}).then(res => res );
	</script>
	</body>
	</html>
	`
		res.Write([]byte(template))
	})

	http.HandleFunc("/on", func(res http.ResponseWriter, req *http.Request) {
		conn, err := net.Dial("tcp", "192.168.12.5:5656")
		if err != nil {
			panic(err)
		}
		defer conn.Close()

		conn.Write([]byte("1"))
	})

	http.HandleFunc("/off", func(res http.ResponseWriter, req *http.Request) {
		conn, err := net.Dial("tcp", "192.168.12.5:5656")
		if err != nil {
			panic(err)
		}
		defer conn.Close()

		conn.Write([]byte("0"))
	})

	http.ListenAndServe(":8080", nil)

}
