//
//  main.swift
//  UserGreeting
//
//  Created by Владислав Стрельников on 16.10.2022.
//

import Foundation

print("write your name and press enter/return:")

if let name = readLine() {
    print("Hello, \(name)!!!")
} else {
    print("Mistake! you didn't enter a name")
}
