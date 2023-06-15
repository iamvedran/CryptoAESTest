# AESEncryption

This is the README file for the `AESEncryption` project, which provides AES encryption and decryption functionality in C#.

## Description

The `AESEncryption` project demonstrates AES (Advanced Encryption Standard) symmetric encryption and decryption. It uses the `AesManaged` class from the `System.Security.Cryptography` namespace.

The project provides the following features:
- Encrypting a string using AES encryption with a given password.
- Decrypting a string using AES decryption with the same password.

## Usage

To use the `AESEncryption` project, follow these steps:

1. Include the `AESEncrtyption` namespace in your code file:
   ```csharp
   using AESEncrtyption;
   ```

2. Encrypt a string:
   ```csharp
   string encryptedText = AES.Encrypt("Plain text", "Password123");
   ```

3. Decrypt the encrypted string:
   ```csharp
   string decryptedText = AES.Decrypt(encryptedText, "Password123");
   ```

Please note that the password should be the same for encryption and decryption.

## Encryption Parameters

The encryption parameters are set within the `SetEncryptionParameters` method. Currently, the initialization vector (IV) and salt bytes are hardcoded in the project. You can modify these values based on your requirements.

## Error Handling

When decrypting a string, if an error occurs during the decryption process, the method will return the string "Došlo je do greške kod dekriptiranja!" (which means "An error occurred during decryption!" in Croatian). You can customize this error message or handle the exception as per your application's needs.
