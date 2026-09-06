$fn= 99;
difference() {
union(){
cube([60,7,7],false);
translate([15,0,0]){
    cube([7,80,7],false);
}
translate([15 + 17 + 7,0,0]){
    cube([7,80,7],false);
}

translate([11 ,0,0]){
    cube([7,80,7],false);
}

translate([60-18 ,0,0]){
    cube([7,80,7],false);
}

}

    #translate([7,8,3.5]) {
    rotate([90,0,0])
    {
    cylinder(h=10,d=4, center=false)
     {}
    }
    }

    #translate([60-7,8,3.5]) {
    rotate([90,0,0])
    {
    cylinder(h=10,d=4, center=false)
     {}
    }
    }

}