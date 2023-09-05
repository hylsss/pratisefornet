using AutoMapper;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectIna;

public class GetStartTest
{
    public static void Test()
    {    //1、创建映射规则
        var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfo, UserInfoDto>());
        var mapper = config.CreateMapper();//或者：var mapper = new Mapper(config);
           //2、把对象映射成需要的对象
        var userInfo = new UserInfo { Name = "BigBox777", Age = 18, Sex = true, Salary = 1.00m };
        UserInfoDto userInfoDto = mapper.Map<UserInfoDto>(userInfo);
        Console.WriteLine(userInfoDto.ToString());

    }
}