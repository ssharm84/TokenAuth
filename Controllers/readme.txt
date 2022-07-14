Client sends a request to server for token
Server generates a JWT (which contains a hash). Hash is generated using a secret key.
Client receives the token and stores it somewhere locally.
Client sends the token in future requests.
Server gets the token from request header, computes Hash again by using a) Header from token b) payload from token c) secret key which server already has.
If ("newly computed hash" = "hash came in token"), token is valid otherwise it is tempered or not valid.

Token is an in-memory: 

eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwidW5pcXVlX25hbWUiOiJzc0BhYmMuY29tIiwibmJmIjoxNjE1NTYzNjA1LCJleHAiOjE2MTU2NTAwMDUsImlhdCI6MTYxNTU2MzYwNX0.0sP6KdwNHpAHb8ZHyozbbcrQ26C4mVFYqQT4osE2P3gut_6_-h3TZ1nD5g4QcsnxnxT17f0eAeHAMbVez99yrA