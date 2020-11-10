var require=function(path){
    var exports={
        getUser:function(){
            return{id:'test01', name: 'evelyn'};
        },
        group:{id:'group01', name:'friends'}
    }
    return exports;
}

var user=require('...');

function showUser(){
    return user.getUser().name+', '+user.group.name;
}

console.log('사용자 정보 : %s', showUser());