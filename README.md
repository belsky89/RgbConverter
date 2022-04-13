# RGB Converter
This project implemented a solution for displaying RGB source decimal values in hexadecimal representation.
Valid decimal values for RGB are 0 - 255. Any values outside this range are rounded up to the nearest valid value.
The response is always 6 characters long.

Examples:
1. Input: "100, 100, 100". Result: "646464"
2. Input: "5, 25, 50".     Result: "051932" 
3. Input: "255, 255, 300". Result: "FFFFFF"
4. Input: "148, 0, 211".   Result: "9400D3"
