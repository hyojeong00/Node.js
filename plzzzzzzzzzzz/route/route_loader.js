var route_loader={};

var config=require('../config');

route_loader.init=function(app,router){
    console.log('route_loader.init 호출됨');
    return initRoutes(app,router);
}

//route_info에 정의된 라우팅 정보처리
function initRoutes(app, router){
    console.log( config )
    var infoLen=config.route_info.length;
    console.log('설정에 정의된 라우팅 모듈 수 : %d',infoLen);

    for(var i=0;i<infoLen;i++){
        var curItem=config.route_info[i];

        var curModule=require(curItem.file);
        console.log('%s 파일에서 모듈정보 읽어옴',curItem.file);

        //라우팅처리
        if(curItem.type=='get'){
            router.route(curItem.path).get(curModule[curItem.method]);
        }else if(curItem.type=='post'){
            router.route(curItem.path).post(curModule[curItem.method]); //콜백 만들어야?
        }else{
            router.route(curItem.path).post(curModule[curItem.method]);
        }
        console.log('라우팅 모듈 [%s]이(가) 설정됨', curItem.method);
    }

    //라우터 객체 등록
    app.use('/',router);
}

module.exports=route_loader;