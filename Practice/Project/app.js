var express= require('express');
var http=require('http');
var path=require('path');

var bodyParser=require('body-parser');
var cookieParser=require('cookie-parser');
var static=require('serve-static');
var errorHandler=require('error-handler');

var expressErrorHandler=require('express-error-handler');

var expressSession=require('express-session');