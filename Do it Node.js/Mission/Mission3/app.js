var express=require('express'), http=require('http'), path=require('path');

var bodyParser=require('body-parser');
var static=require('serve-static');

var expressErrorHandler=require('express-error-handler');

var fs=require('fs');