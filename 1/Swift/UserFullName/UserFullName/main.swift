//
//  main.swift
//  UserFullName
//
//  Created by Владислав Стрельников on 17.10.2022.
//

import Foundation


print("write your first name and press enter/return: ")


if let UserFirstName = readLine(){
    print("write your last name and press enter/return: ")
} else {
    print("Error in name")
}
    

if let UserLastName = readLine(){
    print("write your middle name and press enter/return: ")
} else {
    print("Error in lastname")
}

if let UserMiddleName = readLine(){
    print("\(UserLastName) \(UserFirstName) \(UserMiddleName)")
} else {
    print("Error in midname")
}
let UserLastName = readLine()

