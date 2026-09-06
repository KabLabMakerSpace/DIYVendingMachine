
width = 52;
$fn = 99;
length = 57;

difference() {
  union() {
    cube([length, width, 4], false);
    cube([11, width, 8], false);
    translate([length - 11, 0, 0]) {
      cube([11, width, 8], false);
    }

    translate([11, 0, 6.35]) {
      rotate([270, 0, 0]) {
        cylinder(width, 1.65, 1.65, false);
      }
    }

    translate([length - 11 + 1.3, 0, 6.5]) {
      rotate([270, 0, 0]) {
        cylinder(width, 1.5, 1.5, false);
      }
    }
  }

  // drill holes for the screws
  translate([0, -4, 1]) {
    rotate([90, 00, 90]) {
      translate([7, 8, 3.5]) {
        rotate([90, 0, 0]) {
          cylinder(h=10, d=4, center=false){}
        }
      }

      translate([60 - 7, 8, 3.5]) {
        rotate([90, 0, 0]) {
          cylinder(h=10, d=4, center=false){}
        }
      }
    }
  }

      translate([45, 26, 8]) {
        rotate([45 + 90, 0,90]) {
          cylinder(h=20, d=2.5, center=false){}
        }
      }

}

