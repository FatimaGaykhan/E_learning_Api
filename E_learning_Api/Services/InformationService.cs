using System;
using AutoMapper;
using E_learning_Api.Data;
using E_learning_Api.DTOs.Contacts;
using E_learning_Api.DTOs.Informations;
using E_learning_Api.Models;
using E_learning_Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace E_learning_Api.Services
{
    public class InformationService : IInformationService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public InformationService(AppDbContext context,
                                 IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(InformationCreateDto request)
        {
            await _context.Informations.AddAsync(_mapper.Map<Information>(request));

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existInformation = await _context.Informations.FindAsync(id);

            _context.Informations.Remove(existInformation);

            await _context.SaveChangesAsync();
        }

        public async Task<InformationDetailDto> DetailAsync(int id)
        {
            var result = await _context.Informations.Include(m=>m.Icon).FirstOrDefaultAsync(m=>m.Id==id);

            return _mapper.Map<InformationDetailDto>(result);
        }

        public async Task EditAsync(int id, InformationEditDto request)
        {
            var existInformation = await _context.Informations.FindAsync(id);

            _mapper.Map(request, existInformation);

            await _context.SaveChangesAsync();

        }

        public async Task<bool> ExistExceptByIdAsync(int id, string name)
        {
            return await _context.Informations.AsNoTracking().AnyAsync(m => m.Title == name && m.Id != id);
        }

        public async Task<List<InformationDto>> GetAllAsync()
        {
            return _mapper.Map<List<InformationDto>>(await _context.Informations.AsNoTracking().Include(m => m.Icon).ToListAsync());
        }

        public async Task<SelectList> GetAllSelectedAsync()
        {
            var infos = await _context.Icons.ToListAsync();
            return new SelectList(infos, "Id", "ClassName");
        }

        public async Task<InformationDto> GetByIdAsync(int id)
        {
            return _mapper.Map<InformationDto>(await _context.Informations.AsNoTracking().Include(m => m.Icon).FirstOrDefaultAsync(m => m.Id == id));
        }
    }
}

