# Final-Task-DJI-store-automatic-tests

The final task for the Automatinis Testavimas course of Code Academy, where several automatic tests of DJI Store were performed.

***Preconditions:***
1. User has opened the [DJI store](https://store.dji.com/lt).
2. User has a valid account for the DJI store.
3. User is logged in to the DJI store.
4. Region settings: Lithuania (English / € EUR).

## Test Scenarios (TS), Test Cases (TC)

### TS001: Search and add the product to the cart

- **TC001:** Search for "DJI Mini 3"
  - **TC001.01:** Click the Search icon
  - **TC001.02:** Select "DJI Mini 3" from the drop-down menu
  - **TC001.03:** Click "DJI Mini 3"
  - **TC001.04:** Click "DJI Mini 3Fly More Combo (DJI RC-N1) 658 €" option
  - **TC001.05:** Click the button "Shop Now"
  - **TC001.06:** Click "Continue Without Coverage"
  - **TC001.07:** Click View Cart Checkout
  - **TC001.08:** Verify that product in the cart is "DJI Mini 3 Fly More Combo (DJI RC-N1)"

### TS002: Update and remove the item from the cart

- **TC002:** Update "DJI Mini 3" quantity in the product cart
  - **TC002.01:** Click on the "Cart" button in the top right corner of the page. Two items in the shopping cart are listed for the total sum of 1316 €
  - **TC002.02:** Click on the "+" button next to quantity 2 of the "DJI Mini 3"
  - **TC002.03:** Verify that two items are in the shopping cart

- **TC003:** Remove "DJI Mini 3" products from the cart
  - **TC003.01:** Click on the "Cart" button in the top right corner of the page. [Product cart page](https://store.dji.com/lv/cart?from=store-nav) will open. The products removed from the shopping cart
  - **TC003.02:** Click on the "Recycle bin" icon next to "DJI Mini 3" in the shopping cart
  - **TC003.03:** Verify that the shopping cart is empty and the message "Your Shopping Cart is Empty" is displayed

### TS003: Navigate to the "Refurbished Products" category

- **TC004:** Navigate to the "Official Refurbished" products and select category "Handheld"
  - **TC004.01:** Click the "Official Refurbished"" button in the top navigation menu
  - **TC004.02:** Select category "Handheld"
  - **TC004.03:** Verify that the "Handheld" category is displayed

### TS004: Change the region, language, currency

- **TC005:** Change the region to Latvia (language to English, currency to €)
  - **TC005.01:** Click on the region button in the top right side of navigation menu
  - **TC005.02:** Select "Latvia English/ € EUR" in the Region Selection table
  - **TC005.03:** Verify that the "Latvia English/ € EUR" region is selected
  
<img src="https://stormsend1.djicdn.com/tpc/uploads/carousel/image/0d6a58a5c7ee8f474e5a34113c5d6d37@ultra.jpg" alt="Image" width="300" height="300" />
