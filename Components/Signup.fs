module Signup

open VCanopy.Functions
open CanopyExtensions


let _accountName = css "input[name='name']"
let _accountNameError = css "#bx-form-element-name .bx-form-warn"
let _email = css "input[name='email']"
let _password = css "input[name='password']"

let _submitButton = css "button[type='submit']"