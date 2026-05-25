# DIY Vending Machine

## Basics
- Raspberry Pi 5
  - dotnet 10
  - chromium (kiosk mode)
  - Additional libraries
- Standard equipment rack
- Misc. hardware
- Custom sheet metal Shelves and dividers
- Use of DIN Rail for key component mounting.
  - Power 12v for motors, 5v for PI
  - Breaker/switch
  - Din Rail on back of shelf for adjustable motor positioning.  
- Vending Spiral motors
  - https://a.co/d/016Zia8p
  - https://a.co/d/0eEZmErj
- Concept using inexpensive standard equipment rack
  - https://www.vevor.com/server-rack-c_10750/vevor-10u-open-frame-network-rack-wall-mounted-server-rack-4-post-with-shelves-p_010932903892
- Barcode scanner
  - https://www.aliexpress.us/item/3256808498543619.html?spm=a2g0o.order_detail.order_detail_item.3.6dc8f19cNLnaa0
  - 3D Printed custom mounts
- Relay and Sensor for motors, and other items for PI system
  - https://sequentmicrosystems.com/products/four-relays-four-inputs-for-raspberry-pi
  - https://sequentmicrosystems.com/products/super-watchdog-hat-with-battery-backup-for-raspberry-pi
  - https://sequentmicrosystems.com/products/din-rail-kit-perpendicular-for-raspberry-pi
  - Other accessories from SequentMicroSystems
  - Various monting hardware

## General Architecture
- dotnet web application running on PI Touch screen
- Postgress database, making unit standalone
- Barcode scanner to scan various ID forms
- Relay driven activation of dispensing motors
- WIFI  hotspot for local administration, configurations, and usage data downloads.

## Checkpoints of build progress
### Checkpoint 1
Here is a quick video of the first checkpoint.
- https://youtube.com/shorts/rF5DmClw5Zs?si=EiYUYnB5nRpxue6H

