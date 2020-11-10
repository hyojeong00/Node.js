/*
 * Main
 * @date 2019-05-07
 * @author LCY
 */

var main = function(req, res) {

  res.render('index.ejs', {param:req});
  
};

module.exports.main = main;


